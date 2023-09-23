using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PhotoFiltering {
	class Noise {

		public static void AddPoints(ref Bitmap modified, int count, int max_size) {
			/*
			 * Добавление шума в виде рандомных точек (прямоугольников)
			 */

			// максимальный размер стороны прямоугольника
			int MAX_SIZE = max_size;

			// минимумы и максимумы в которых выбираются координаты точек для шума
			int MIN_X = 0;
			int MAX_X = modified.Width - MAX_SIZE;

			int MIN_Y = 0;
			int MAX_Y = modified.Height - MAX_SIZE;

			// рандомщик
			var random = new Random();

			// создаем рандомный шум в количестве count
			for (int i = 0; i < count; i++) {
				// рандомная координата
				int x = random.Next(MIN_X, MAX_X);
				int y = random.Next(MIN_Y, MAX_Y);

				// рандомный размер
				int x_size = random.Next(1, MAX_SIZE+1);
				int y_size = random.Next(1, MAX_SIZE+1);

				// для рисования
				Graphics g = Graphics.FromImage(modified);
				
				// выбор каким цветом сделать точку - черная или белая
				if (i % 2 == 0)
					g.FillRectangle(new SolidBrush(Color.Black), x, y, x_size, y_size);
				else
					g.FillRectangle(new SolidBrush(Color.White), x, y, x_size, y_size);
			}
		}
	}
}
