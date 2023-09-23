using System.Collections.Generic;
using System.Drawing;

namespace PhotoFiltering {
	class MedianFilter {

		public static void Apply(Bitmap original, ref Bitmap modified, int matrix_size) {
			/*
			 * Медианный фильтр
			 * Справляется с импульсными помехами
			 */

			// размер смещения
			int ms = matrix_size / 2;

			// размеры изображения
			int WIDTH = original.Width;
			int HEIGHT = original.Height;

			for (int y = 0; y < HEIGHT; y++)
				for (int x = 0; x < WIDTH; x++) {

					// сделать список пикселей и отсортировать его
					List<int> pixels = new List<int>();

					// в список попадают пиксели, находящиеся вокруг текущего
					// собираются все пиксели которые находятся слева/справа/сверху/снизу и по диагоналям
					// от текущего пикселя + в список добавляется сам текущий пиксель конечно же
					for (int i = x - ms; i <= x + ms; i++)
						for (int j = y - ms; j <= y + ms; j++) {

							if (i < 0 || j < 0 || i > WIDTH - 1 || j > HEIGHT - 1)
								continue;
							pixels.Add(original.GetPixel(i, j).ToArgb());
						}

					// сортировка пикселей в списке
					pixels.Sort();

					// индекс пикселя медианы
					int median_index = (pixels.Count - 1) / 2;

					// в результирующее изображение ставим найденный медианный пиксель
					modified.SetPixel(x, y, Color.FromArgb(pixels[median_index]));
				}
		}

	}
}
