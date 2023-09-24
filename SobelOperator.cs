using System.Drawing;

namespace PhotoFiltering {
	class SobelOperator {
		/// <summary>
		/// Оператор Собеля для оконтуривония
		/// </summary>
		/// <param name="original"></param>
		/// <param name="modified"></param>
		public static void Apply(Bitmap original, ref Bitmap modified) {

			int WIDTH = original.Width;
			int HEIGHT = original.Height;

			// Матрицы
			int[,] gx = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
			int[,] gy = new int[,] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };

			// Буферы под составляющие цветов
			int[,] allPixR = new int[WIDTH, HEIGHT];
			int[,] allPixG = new int[WIDTH, HEIGHT];
			int[,] allPixB = new int[WIDTH, HEIGHT];

			int limit = 128 * 128;

			// Заполнение буферов
			for (int i = 0; i < WIDTH; i++) {
				for (int j = 0; j < HEIGHT; j++) {
					allPixR[i, j] = original.GetPixel(i, j).R;
					allPixG[i, j] = original.GetPixel(i, j).G;
					allPixB[i, j] = original.GetPixel(i, j).B;
				}
			}

			int rc, gc, bc;

			for (int i = 1; i < WIDTH - 1; i++) {
				for (int j = 1; j < HEIGHT - 1; j++) {

					int newRX = 0, newRY = 0;
					int newGX = 0, newGY = 0;
					int newBX = 0, newBY = 0;

					for (int wi = -1; wi < 2; wi++) {
						for (int hw = -1; hw < 2; hw++) {
							rc = allPixR[i + hw, j + wi];
							newRX += gx[wi + 1, hw + 1] * rc;
							newRY += gy[wi + 1, hw + 1] * rc;

							gc = allPixG[i + hw, j + wi];
							newGX += gx[wi + 1, hw + 1] * gc;
							newGY += gy[wi + 1, hw + 1] * gc;

							bc = allPixB[i + hw, j + wi];
							newBX += gx[wi + 1, hw + 1] * bc;
							newBY += gy[wi + 1, hw + 1] * bc;
						}
					}

					if (newRX * newRX + newRY * newRY > limit ||
						newGX * newGX + newGY * newGY > limit ||
						newBX * newBX + newBY * newBY > limit
					) {
						modified.SetPixel(i, j, Color.White);
					}
					else {
						modified.SetPixel(i, j, Color.Black);
					}
				}
			}
		}
	}
}
