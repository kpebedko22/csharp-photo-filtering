
namespace PhotoFiltering {
	partial class MainForm {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenFile_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsFile_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OriginalRecover_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label_original_image = new System.Windows.Forms.Label();
			this.label_modified_image = new System.Windows.Forms.Label();
			this.pictureBox_original = new System.Windows.Forms.PictureBox();
			this.pictureBox_modified = new System.Windows.Forms.PictureBox();
			this.button_remember_modified = new System.Windows.Forms.Button();
			this.button_median_filter = new System.Windows.Forms.Button();
			this.button_gaussian_filter = new System.Windows.Forms.Button();
			this.button_sobel_operator = new System.Windows.Forms.Button();
			this.comboBox_median_filter = new System.Windows.Forms.ComboBox();
			this.button_add_noise = new System.Windows.Forms.Button();
			this.comboBox_gaussian_filter = new System.Windows.Forms.ComboBox();
			this.numericUpDown_gaussian_filter = new System.Windows.Forms.NumericUpDown();
			this.button_sharpening = new System.Windows.Forms.Button();
			this.numericUpDown_sharpening_degree = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_noise = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_modified)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gaussian_filter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sharpening_degree)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_noise)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1054, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// File_ToolStripMenuItem
			// 
			this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile_ToolStripMenuItem,
            this.SaveAsFile_ToolStripMenuItem,
            this.OriginalRecover_ToolStripMenuItem});
			this.File_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
			this.File_ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.File_ToolStripMenuItem.Text = "Файл";
			// 
			// OpenFile_ToolStripMenuItem
			// 
			this.OpenFile_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.OpenFile_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.OpenFile_ToolStripMenuItem.Name = "OpenFile_ToolStripMenuItem";
			this.OpenFile_ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.OpenFile_ToolStripMenuItem.Text = "Открыть";
			this.OpenFile_ToolStripMenuItem.Click += new System.EventHandler(this.OpenFile_ToolStripMenuItem_Click);
			// 
			// SaveAsFile_ToolStripMenuItem
			// 
			this.SaveAsFile_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.SaveAsFile_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.SaveAsFile_ToolStripMenuItem.Name = "SaveAsFile_ToolStripMenuItem";
			this.SaveAsFile_ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.SaveAsFile_ToolStripMenuItem.Text = "Сохранить как...";
			this.SaveAsFile_ToolStripMenuItem.Click += new System.EventHandler(this.SaveAsFile_ToolStripMenuItem_Click);
			// 
			// OriginalRecover_ToolStripMenuItem
			// 
			this.OriginalRecover_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.OriginalRecover_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.OriginalRecover_ToolStripMenuItem.Name = "OriginalRecover_ToolStripMenuItem";
			this.OriginalRecover_ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.OriginalRecover_ToolStripMenuItem.Text = "Восстановить исходное";
			this.OriginalRecover_ToolStripMenuItem.Click += new System.EventHandler(this.OriginalRecover_ToolStripMenuItem_Click);
			// 
			// label_original_image
			// 
			this.label_original_image.AutoSize = true;
			this.label_original_image.ForeColor = System.Drawing.Color.White;
			this.label_original_image.Location = new System.Drawing.Point(8, 24);
			this.label_original_image.Name = "label_original_image";
			this.label_original_image.Size = new System.Drawing.Size(184, 21);
			this.label_original_image.TabIndex = 2;
			this.label_original_image.Text = "Исходное изображение:";
			// 
			// label_modified_image
			// 
			this.label_modified_image.AutoSize = true;
			this.label_modified_image.ForeColor = System.Drawing.Color.White;
			this.label_modified_image.Location = new System.Drawing.Point(526, 24);
			this.label_modified_image.Name = "label_modified_image";
			this.label_modified_image.Size = new System.Drawing.Size(263, 21);
			this.label_modified_image.TabIndex = 5;
			this.label_modified_image.Text = "Модифицированное изображение:";
			// 
			// pictureBox_original
			// 
			this.pictureBox_original.Location = new System.Drawing.Point(12, 48);
			this.pictureBox_original.Name = "pictureBox_original";
			this.pictureBox_original.Size = new System.Drawing.Size(512, 512);
			this.pictureBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_original.TabIndex = 6;
			this.pictureBox_original.TabStop = false;
			// 
			// pictureBox_modified
			// 
			this.pictureBox_modified.Location = new System.Drawing.Point(530, 48);
			this.pictureBox_modified.Name = "pictureBox_modified";
			this.pictureBox_modified.Size = new System.Drawing.Size(512, 512);
			this.pictureBox_modified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_modified.TabIndex = 7;
			this.pictureBox_modified.TabStop = false;
			// 
			// button_remember_modified
			// 
			this.button_remember_modified.Location = new System.Drawing.Point(792, 659);
			this.button_remember_modified.Name = "button_remember_modified";
			this.button_remember_modified.Size = new System.Drawing.Size(250, 30);
			this.button_remember_modified.TabIndex = 20;
			this.button_remember_modified.Text = "Запомнить модификацию";
			this.button_remember_modified.UseVisualStyleBackColor = true;
			this.button_remember_modified.Click += new System.EventHandler(this.button_remember_modified_Click);
			// 
			// button_median_filter
			// 
			this.button_median_filter.Location = new System.Drawing.Point(12, 622);
			this.button_median_filter.Name = "button_median_filter";
			this.button_median_filter.Size = new System.Drawing.Size(170, 30);
			this.button_median_filter.TabIndex = 21;
			this.button_median_filter.Text = "Медианный фильтр";
			this.button_median_filter.UseVisualStyleBackColor = true;
			this.button_median_filter.Click += new System.EventHandler(this.button_median_filter_Click);
			// 
			// button_gaussian_filter
			// 
			this.button_gaussian_filter.Location = new System.Drawing.Point(188, 622);
			this.button_gaussian_filter.Name = "button_gaussian_filter";
			this.button_gaussian_filter.Size = new System.Drawing.Size(170, 30);
			this.button_gaussian_filter.TabIndex = 23;
			this.button_gaussian_filter.Text = "Фильтр Гаусса";
			this.button_gaussian_filter.UseVisualStyleBackColor = true;
			this.button_gaussian_filter.Click += new System.EventHandler(this.button_gaussian_filter_Click);
			// 
			// button_sobel_operator
			// 
			this.button_sobel_operator.Location = new System.Drawing.Point(488, 622);
			this.button_sobel_operator.Name = "button_sobel_operator";
			this.button_sobel_operator.Size = new System.Drawing.Size(171, 30);
			this.button_sobel_operator.TabIndex = 24;
			this.button_sobel_operator.Text = "Собель";
			this.button_sobel_operator.UseVisualStyleBackColor = true;
			this.button_sobel_operator.Click += new System.EventHandler(this.button_sobel_operator_Click);
			// 
			// comboBox_median_filter
			// 
			this.comboBox_median_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_median_filter.Location = new System.Drawing.Point(12, 587);
			this.comboBox_median_filter.Name = "comboBox_median_filter";
			this.comboBox_median_filter.Size = new System.Drawing.Size(90, 29);
			this.comboBox_median_filter.TabIndex = 25;
			// 
			// button_add_noise
			// 
			this.button_add_noise.Location = new System.Drawing.Point(871, 622);
			this.button_add_noise.Name = "button_add_noise";
			this.button_add_noise.Size = new System.Drawing.Size(171, 30);
			this.button_add_noise.TabIndex = 26;
			this.button_add_noise.Text = "Добавить шум";
			this.button_add_noise.UseVisualStyleBackColor = true;
			this.button_add_noise.Click += new System.EventHandler(this.button_add_noise_Click);
			// 
			// comboBox_gaussian_filter
			// 
			this.comboBox_gaussian_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_gaussian_filter.Location = new System.Drawing.Point(188, 586);
			this.comboBox_gaussian_filter.Name = "comboBox_gaussian_filter";
			this.comboBox_gaussian_filter.Size = new System.Drawing.Size(90, 29);
			this.comboBox_gaussian_filter.TabIndex = 27;
			// 
			// numericUpDown_gaussian_filter
			// 
			this.numericUpDown_gaussian_filter.DecimalPlaces = 2;
			this.numericUpDown_gaussian_filter.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDown_gaussian_filter.Location = new System.Drawing.Point(289, 587);
			this.numericUpDown_gaussian_filter.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown_gaussian_filter.Name = "numericUpDown_gaussian_filter";
			this.numericUpDown_gaussian_filter.Size = new System.Drawing.Size(69, 29);
			this.numericUpDown_gaussian_filter.TabIndex = 28;
			this.numericUpDown_gaussian_filter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// button_sharpening
			// 
			this.button_sharpening.Location = new System.Drawing.Point(665, 622);
			this.button_sharpening.Name = "button_sharpening";
			this.button_sharpening.Size = new System.Drawing.Size(200, 30);
			this.button_sharpening.TabIndex = 29;
			this.button_sharpening.Text = "Повышение резкости";
			this.button_sharpening.UseVisualStyleBackColor = true;
			this.button_sharpening.Click += new System.EventHandler(this.button_sharpening_Click);
			// 
			// numericUpDown_sharpening_degree
			// 
			this.numericUpDown_sharpening_degree.DecimalPlaces = 2;
			this.numericUpDown_sharpening_degree.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDown_sharpening_degree.Location = new System.Drawing.Point(665, 590);
			this.numericUpDown_sharpening_degree.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown_sharpening_degree.Name = "numericUpDown_sharpening_degree";
			this.numericUpDown_sharpening_degree.Size = new System.Drawing.Size(69, 29);
			this.numericUpDown_sharpening_degree.TabIndex = 30;
			this.numericUpDown_sharpening_degree.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDown_noise
			// 
			this.numericUpDown_noise.Location = new System.Drawing.Point(871, 590);
			this.numericUpDown_noise.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown_noise.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_noise.Name = "numericUpDown_noise";
			this.numericUpDown_noise.Size = new System.Drawing.Size(69, 29);
			this.numericUpDown_noise.TabIndex = 31;
			this.numericUpDown_noise.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(8, 563);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 21);
			this.label1.TabIndex = 32;
			this.label1.Text = "Медианный фильтр:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(184, 562);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 21);
			this.label2.TabIndex = 33;
			this.label2.Text = "Фильтр Гаусса:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(484, 566);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 21);
			this.label3.TabIndex = 34;
			this.label3.Text = "Оконтуривание:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(661, 566);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(167, 21);
			this.label4.TabIndex = 35;
			this.label4.Text = "Повышение резкости:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(867, 566);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(144, 21);
			this.label5.TabIndex = 36;
			this.label5.Text = "Добавление шума:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ClientSize = new System.Drawing.Size(1054, 701);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDown_noise);
			this.Controls.Add(this.numericUpDown_sharpening_degree);
			this.Controls.Add(this.button_sharpening);
			this.Controls.Add(this.numericUpDown_gaussian_filter);
			this.Controls.Add(this.comboBox_gaussian_filter);
			this.Controls.Add(this.button_add_noise);
			this.Controls.Add(this.comboBox_median_filter);
			this.Controls.Add(this.button_sobel_operator);
			this.Controls.Add(this.button_gaussian_filter);
			this.Controls.Add(this.button_median_filter);
			this.Controls.Add(this.button_remember_modified);
			this.Controls.Add(this.pictureBox_modified);
			this.Controls.Add(this.pictureBox_original);
			this.Controls.Add(this.label_modified_image);
			this.Controls.Add(this.label_original_image);
			this.Controls.Add(this.menuStrip);
			this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.Text = "Фотофильтры";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_modified)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gaussian_filter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sharpening_degree)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_noise)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenFile_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveAsFile_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OriginalRecover_ToolStripMenuItem;
		private System.Windows.Forms.Label label_original_image;
		private System.Windows.Forms.Label label_modified_image;
		private System.Windows.Forms.PictureBox pictureBox_original;
		private System.Windows.Forms.PictureBox pictureBox_modified;
		private System.Windows.Forms.Button button_remember_modified;
		private System.Windows.Forms.Button button_median_filter;
		private System.Windows.Forms.Button button_gaussian_filter;
		private System.Windows.Forms.Button button_sobel_operator;
		private System.Windows.Forms.ComboBox comboBox_median_filter;
		private System.Windows.Forms.Button button_add_noise;
		private System.Windows.Forms.ComboBox comboBox_gaussian_filter;
		private System.Windows.Forms.NumericUpDown numericUpDown_gaussian_filter;
		private System.Windows.Forms.Button button_sharpening;
		private System.Windows.Forms.NumericUpDown numericUpDown_sharpening_degree;
		private System.Windows.Forms.NumericUpDown numericUpDown_noise;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}

