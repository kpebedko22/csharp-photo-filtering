using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace PhotoFiltering {
	class Sharpening {
		/// <summary>
		/// Повышение резкости изображения, используя матрицу 3х3
		/// </summary>
		/// <param name="original"></param>
		/// <param name="modified"></param>
		/// <param name="k"></param>
		public static void Apply(Bitmap original, ref Bitmap modified, double k) {

			Bitmap sharpenImage = (Bitmap)original.Clone();

			int width = original.Width;
			int height = original.Height;

			// Фильтр повышения резкости
			int filterWidth = 3, filterHeight = 3;
			double[,] filter = new double[,] {
				{ -k/8 , -k/8, -k/8 },
				{ -k/8 , k + 1, -k/8 },
				{ -k/8 , -k/8, -k/8 }
			};

			double factor = 1.0;
			double bias = 0.0;

			Color[,] result = new Color[width, height];

			BitmapData srcData = sharpenImage.LockBits(
				new Rectangle(0, 0, width, height),
				ImageLockMode.ReadWrite,
				PixelFormat.Format24bppRgb
			);

			int bytes = srcData.Stride * srcData.Height;
			byte[] buffer = new byte[bytes];

			Marshal.Copy(srcData.Scan0, buffer, 0, bytes);

			int rgb;
			for (int x = 0; x < width; ++x) {
				for (int y = 0; y < height; ++y) {
					double red = 0.0, green = 0.0, blue = 0.0;

					for (int filterX = 0; filterX < filterWidth; filterX++) {
						for (int filterY = 0; filterY < filterHeight; filterY++) {
							int imageX = (x - filterWidth / 2 + filterX + width) % width;
							int imageY = (y - filterHeight / 2 + filterY + height) % height;

							rgb = imageY * srcData.Stride + 3 * imageX;

							red += buffer[rgb + 2] * filter[filterX, filterY];
							green += buffer[rgb + 1] * filter[filterX, filterY];
							blue += buffer[rgb + 0] * filter[filterX, filterY];
						}

						int r = Math.Min(Math.Max((int)(factor * red + bias), 0), 255);
						int g = Math.Min(Math.Max((int)(factor * green + bias), 0), 255);
						int b = Math.Min(Math.Max((int)(factor * blue + bias), 0), 255);

						result[x, y] = Color.FromArgb(r, g, b);
					}
				}
			}

			for (int x = 0; x < width; ++x) {
				for (int y = 0; y < height; ++y) {
					rgb = y * srcData.Stride + 3 * x;

					buffer[rgb + 2] = result[x, y].R;
					buffer[rgb + 1] = result[x, y].G;
					buffer[rgb + 0] = result[x, y].B;
				}
			}

			Marshal.Copy(buffer, 0, srcData.Scan0, bytes);
			sharpenImage.UnlockBits(srcData);

			// Копируем в modified полученное изображение с повышенной резкостью
			modified = (Bitmap)sharpenImage.Clone();

			// Освобождаем ресурсы
			sharpenImage.Dispose();
		}
	}
}
