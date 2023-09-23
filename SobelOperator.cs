using System.Drawing;

namespace PhotoFiltering {
	class SobelOperator {

        public static void Apply(Bitmap original, ref Bitmap modified) {
            /*
             * Оператор Собеля для оконтуривония
             */

            int WIDTH = original.Width;
            int HEIGHT = original.Height;

            // матрицы
            int[,] gx = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int[,] gy = new int[,] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };

            // буферы под составляющие цветов
            int[,] allPixR = new int[WIDTH, HEIGHT];
            int[,] allPixG = new int[WIDTH, HEIGHT];
            int[,] allPixB = new int[WIDTH, HEIGHT];

            int limit = 128 * 128;

            // заполняем буферы
            for (int i = 0; i < WIDTH; i++)
                for (int j = 0; j < HEIGHT; j++) {
                    allPixR[i, j] = original.GetPixel(i, j).R;
                    allPixG[i, j] = original.GetPixel(i, j).G;
                    allPixB[i, j] = original.GetPixel(i, j).B;
                }

            int rc, gc, bc;

            for (int i = 1; i < WIDTH - 1; i++) {
                for (int j = 1; j < HEIGHT - 1; j++) {

                    int new_rx = 0, new_ry = 0;
                    int new_gx = 0, new_gy = 0;
                    int new_bx = 0, new_by = 0;

                    for (int wi = -1; wi < 2; wi++) {
                        for (int hw = -1; hw < 2; hw++) {
                            rc = allPixR[i + hw, j + wi];
                            new_rx += gx[wi + 1, hw + 1] * rc;
                            new_ry += gy[wi + 1, hw + 1] * rc;

                            gc = allPixG[i + hw, j + wi];
                            new_gx += gx[wi + 1, hw + 1] * gc;
                            new_gy += gy[wi + 1, hw + 1] * gc;

                            bc = allPixB[i + hw, j + wi];
                            new_bx += gx[wi + 1, hw + 1] * bc;
                            new_by += gy[wi + 1, hw + 1] * bc;
                        }
                    }

                    if (new_rx * new_rx + new_ry * new_ry > limit ||
                        new_gx * new_gx + new_gy * new_gy > limit ||
                        new_bx * new_bx + new_by * new_by > limit)
                        modified.SetPixel(i, j, Color.White);
                    else
                        modified.SetPixel(i, j, Color.Black);
                }
            }
        }
    }
}
