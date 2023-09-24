using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhotoFiltering {
	public partial class MainForm : Form {

		private static readonly string[] availableValuesSTRMedianFilter = new string[] {
			"3x3", "5x5", "7x7", "9x9", "11x11", "13x13", "15x15"
		};

		private static readonly int[] availableValuesINTMedianFilter = new int[] {
			3, 5, 7, 9, 11, 13, 15
		};

		public static Bitmap originalImageForRecover;
		public static Bitmap originalImage;
		public static Bitmap modifiedImage;

		private static bool isFileOpened = false;

		public MainForm() {
			// Инициализация компонентов формы
			InitializeComponent();

			// Добавление в выпадающий список наименований доступных опций
			// Для медианного фильтра и фильтра Гаусса
			comboBoxMedianFilter.Items.AddRange(availableValuesSTRMedianFilter);
			comboBoxMedianFilter.SelectedIndex = 0;
			comboBoxGaussianFilter.Items.AddRange(availableValuesSTRMedianFilter);
			comboBoxGaussianFilter.SelectedIndex = 0;
		}

		/// <summary>
		/// Обновить элементы на форме
		/// </summary>
		private void UpdateGUI() {
			pictureBoxOriginal.Image = originalImage;
			pictureBoxModified.Image = modifiedImage;
		}

		/// <summary>
		/// Показать модифицированное изображение
		/// </summary>
		public void ShowModified() {
			pictureBoxModified.Image = modifiedImage;
		}

		/// <summary>
		/// Эвент выбора изображения с помощью диалогового окна
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemOpenFileClick(object sender, EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog {
				Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				try {
					isFileOpened = openFileDialog.FileName != "\0";

					originalImage = new Bitmap(openFileDialog.FileName);
					modifiedImage = new Bitmap(openFileDialog.FileName);
					originalImageForRecover = new Bitmap(openFileDialog.FileName);

					UpdateGUI();
				}
				catch {
					isFileOpened = false;

					MessageBox.Show(
						"Невозможно открыть выбранный файл",
						"Ошибка",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);
				}
			}
		}

		/// <summary>
		/// Эвент сохранения изображения с помощью диалогового окна
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemSaveAsFileClick(object sender, EventArgs e) {
			if (!isFileOpened) {
				return;
			}

			SaveFileDialog saveFileDialog = new SaveFileDialog {
				Title = "Сохранить картинку как...",
				OverwritePrompt = true,
				CheckPathExists = true,
				Filter = "Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*",
				ShowHelp = true
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK) {
				try {
					modifiedImage.Save(
						saveFileDialog.FileName,
						System.Drawing.Imaging.ImageFormat.Jpeg
					);
				}
				catch {
					MessageBox.Show(
						"Невозможно сохранить изображение",
						"Ошибка",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);
				}
			}
		}

		/// <summary>
		/// Эвент нажатия на кнопку для восстановления исходного изображения как текущего
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ToolStripMenuItemOriginalRecoverClick(object sender, EventArgs e) {
			if (!isFileOpened) {
				return;
			}

			originalImage.Dispose();
			modifiedImage.Dispose();

			originalImage = new Bitmap(originalImageForRecover);
			modifiedImage = new Bitmap(originalImageForRecover);

			UpdateGUI();
		}

		/// <summary>
		/// Эвент нажатия на кнопку для сохранения последней модификации в качестве текущего изображения
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonRememberModifiedClick(object sender, EventArgs e) {
			if (!isFileOpened) {
				return;
			}

			Bitmap tmp = new Bitmap(modifiedImage);

			originalImage.Dispose();
			modifiedImage.Dispose();

			originalImage = new Bitmap(tmp);
			modifiedImage = new Bitmap(tmp);

			tmp.Dispose();

			UpdateGUI();
		}

		/// <summary>
		/// Эвент нажатия на кнопку применения медианного фильтра
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonMedianFilterClick(object sender, EventArgs e) {
			if (!isFileOpened) {
				return;
			}

			MedianFilter.Apply(
				originalImage,
				ref modifiedImage,
				availableValuesINTMedianFilter[comboBoxMedianFilter.SelectedIndex]
			);

			ShowModified();
		}

		/// <summary>
		/// Эвент нажатия на кнопку применения фильтра Гаусса
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonGaussianFilterClick(object sender, EventArgs e) {
			if (!isFileOpened) {
				return;
			}

			GaussianFilter.Apply(
				originalImage,
				ref modifiedImage,
				availableValuesINTMedianFilter[comboBoxGaussianFilter.SelectedIndex],
				(double)numericUpDownGaussianFilterWeight.Value
			);

			ShowModified();
		}

		/// <summary>
		/// Эвент нажатия на кнопку применения оконтуривания по Собелю
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonSobelOperatorClick(object sender, EventArgs e) {
			if (!isFileOpened) {
				return;
			}

			SobelOperator.Apply(originalImage, ref modifiedImage);

			ShowModified();
		}

		/// <summary>
		/// Эвент нажатия на кнопку для добавления шума
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonAddNoiseClick(object sender, EventArgs e) {
			if (!isFileOpened) {
				return;
			}

			Noise.AddPoints(ref modifiedImage, 100, (int)numericUpDownNoise.Value);

			ShowModified();
		}

		/// <summary>
		/// Эвент нажатия на кнопку для повышения резкости
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonSharpeningClick(object sender, EventArgs e) {
			if (!isFileOpened) {
				return;
			}

			Sharpening.Apply(
				originalImage,
				ref modifiedImage,
				(double)numericUpDownSharpeningDegree.Value
			);

			ShowModified();
		}
	}
}
