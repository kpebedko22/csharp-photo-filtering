using System;
using System.Drawing;

namespace PhotoFiltering {
	class Noise {
		/// <summary>
		/// Добавление шума в виде рандомных точек (прямоугольников)
		/// </summary>
		/// <param name="modified"></param>
		/// <param name="count"></param>
		/// <param name="maxSize">Максимальный размер стороны прямоугольника</param>
		public static void AddPoints(ref Bitmap modified, int count, int maxSize) {

			// Минимумы и максимумы, в которых выбираются координаты точек для шума
			int minX = 0;
			int maxX = modified.Width - maxSize;

			int minY = 0;
			int maxY = modified.Height - maxSize;

			var random = new Random();

			// Создание рандомного шума (в количестве count)
			for (int i = 0; i < count; i++) {
				// Рандомная координата
				int x = random.Next(minX, maxX);
				int y = random.Next(minY, maxY);

				// Рандомный размер
				int width = random.Next(1, maxSize + 1);
				int height = random.Next(1, maxSize + 1);

				Graphics g = Graphics.FromImage(modified);

				// Цвет, чтобы сделать точку - черная или белая
				Color color = i % 2 == 0
					? Color.Black
					: Color.White;

				g.FillRectangle(new SolidBrush(color), x, y, width, height);
			}
		}
	}
}
