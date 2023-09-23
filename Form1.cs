using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoFiltering {
	public partial class MainForm : Form {

		private static string[] availableValuesSTRMedianFilter = new string[] {
			"3x3", "5x5", "7x7", "9x9", "11x11", "13x13", "15x15"
		};

		private static int[] availableValuesINTMedianFilter = new int[] {
			3, 5, 7, 9, 11, 13, 15
		};

		public MainForm() {
			// инициализирую компоненты формы
			InitializeComponent();

			// добавляю в выпадающий список наименования доступных опций
			comboBox_median_filter.Items.AddRange(availableValuesSTRMedianFilter);
			comboBox_median_filter.SelectedIndex = 0;

			// добавляю в выпадающий список наименования доступных опций
			comboBox_gaussian_filter.Items.AddRange(availableValuesSTRMedianFilter);
			comboBox_gaussian_filter.SelectedIndex = 0;
		}

		public static Bitmap original_image_for_recover;
		public static Bitmap original_image;
		public static Bitmap modified_image;

		public static string full_name_of_image = "\0";

		private void OpenFile_ToolStripMenuItem_Click(object sender, EventArgs e) {
			/* Выбор изображение с помощью диалогового окна */

			OpenFileDialog open_dialog = new OpenFileDialog();
			open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

			if (open_dialog.ShowDialog() == DialogResult.OK) {
				try {
					full_name_of_image = open_dialog.FileName;

					original_image = new Bitmap(open_dialog.FileName);
					modified_image = new Bitmap(open_dialog.FileName);
					original_image_for_recover = new Bitmap(open_dialog.FileName);

					UpdateGUI();
				}
				catch {
					full_name_of_image = "\0";
					DialogResult result = MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void SaveAsFile_ToolStripMenuItem_Click(object sender, EventArgs e) {
			/* Сохранение изображения с помощью диалогового окна */

			if (full_name_of_image != "\0") {
				SaveFileDialog savedialog = new SaveFileDialog();
				savedialog.Title = "Сохранить картинку как...";
				savedialog.OverwritePrompt = true;
				savedialog.CheckPathExists = true;
				savedialog.Filter = "Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
				savedialog.ShowHelp = true;
				if (savedialog.ShowDialog() == DialogResult.OK) {
					try {
						modified_image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
					}
					catch {
						MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void OriginalRecover_ToolStripMenuItem_Click(object sender, EventArgs e) {
			/* Восстановить исходное изображение как текущее */
			if (full_name_of_image != "\0") {
				original_image.Dispose();
				modified_image.Dispose();

				original_image = new Bitmap(original_image_for_recover);
				modified_image = new Bitmap(original_image_for_recover);

				UpdateGUI();
			}
		}

		private void UpdateGUI() {
			/* Обновить элементы управления на форме */
			pictureBox_original.Image = original_image;
			pictureBox_modified.Image = modified_image;
		}

		public void ShowModified() {
			pictureBox_modified.Image = modified_image;
		}

		private void button_remember_modified_Click(object sender, EventArgs e) {
			/* Сохранить последнюю модификацию как текущее изображение */
			if (full_name_of_image != "\0") {
				Bitmap temp = new Bitmap(modified_image);

				original_image.Dispose();
				modified_image.Dispose();
				original_image = new Bitmap(temp);
				modified_image = new Bitmap(temp);

				temp.Dispose();

				UpdateGUI();
			}
		}

		private void button_median_filter_Click(object sender, EventArgs e) {
			/* Применить медианный фильтр */
			if (full_name_of_image != "\0") {
				int index = availableValuesINTMedianFilter[comboBox_median_filter.SelectedIndex];

				MedianFilter.Apply(original_image, ref modified_image, index);

				ShowModified();
			}
		}

		private void button_gaussian_filter_Click(object sender, EventArgs e) {
			/* Применить фильтр Гаусса */
			if (full_name_of_image != "\0") {

				int l = availableValuesINTMedianFilter[comboBox_gaussian_filter.SelectedIndex]; 
				double w = (double)numericUpDown_gaussian_filter.Value;

				GaussianFilter.Apply(original_image, ref modified_image, l, w);

				ShowModified();
			}
		}

		private void button_sobel_operator_Click(object sender, EventArgs e) {
			/* Применить Оконтуривание по Собелю */
			if (full_name_of_image != "\0") {

				SobelOperator.Apply(original_image, ref modified_image);

				ShowModified();
			}
		}

		private void button_add_noise_Click(object sender, EventArgs e) {
			/* Применить Оконтуривание по Собелю */
			if (full_name_of_image != "\0") {

				int size = (int)numericUpDown_noise.Value;

				Noise.AddPoints(ref modified_image, 100, size);

				ShowModified();
			}
		}

		private void button_sharpening_Click(object sender, EventArgs e) {
			/* Применить повышение резкости */
			if (full_name_of_image != "\0") {

				double k = (double)numericUpDown_sharpening_degree.Value;

				Sharpening.Apply(original_image, ref modified_image, k);

				ShowModified();
			}
		}
	}
}
