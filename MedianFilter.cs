using System.Collections.Generic;
using System.Drawing;

namespace PhotoFiltering {
	class MedianFilter {
		/// <summary>
		/// Применения медианного фильтра.
		/// Справляется с импульсными помехами.
		/// </summary>
		/// <param name="original"></param>
		/// <param name="modified"></param>
		/// <param name="matrixSize"></param>
		public static void Apply(Bitmap original, ref Bitmap modified, int matrixSize) {
			// Размер смещения
			int ms = matrixSize / 2;

			// Размеры изображения
			int WIDTH = original.Width;
			int HEIGHT = original.Height;

			for (int y = 0; y < HEIGHT; y++) {
				for (int x = 0; x < WIDTH; x++) {

					// Собрать список пикселей и отсортировать его
					List<int> pixels = new List<int>();

					// В список попадают пиксели, находящиеся вокруг текущего.
					// Собираются все пиксели, которые находятся слева/справа/сверху/снизу и по диагоналям, 
					// от текущего пикселя. В список добавляется текущий пиксель.
					for (int i = x - ms; i <= x + ms; i++) {
						for (int j = y - ms; j <= y + ms; j++) {

							if (i < 0 || j < 0 || i > WIDTH - 1 || j > HEIGHT - 1) {
								continue;
							}

							pixels.Add(original.GetPixel(i, j).ToArgb());
						}
					}

					// Сортировка пикселей
					pixels.Sort();

					// Индекс пикселя медианы
					int medianIndex = (pixels.Count - 1) / 2;

					// В результирующее изображение устанавливается найденный медианный пиксель
					modified.SetPixel(x, y, Color.FromArgb(pixels[medianIndex]));
				}
			}
		}
	}
}
