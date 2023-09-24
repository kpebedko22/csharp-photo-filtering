
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
			this.ToolStripMenuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemSaveAsFile = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemOriginalRecover = new System.Windows.Forms.ToolStripMenuItem();
			this.label_original_image = new System.Windows.Forms.Label();
			this.label_modified_image = new System.Windows.Forms.Label();
			this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
			this.pictureBoxModified = new System.Windows.Forms.PictureBox();
			this.buttonRememberModified = new System.Windows.Forms.Button();
			this.buttonMedianFilter = new System.Windows.Forms.Button();
			this.buttonGaussianFilter = new System.Windows.Forms.Button();
			this.buttonSobelOperator = new System.Windows.Forms.Button();
			this.comboBoxMedianFilter = new System.Windows.Forms.ComboBox();
			this.buttonAddNoise = new System.Windows.Forms.Button();
			this.comboBoxGaussianFilter = new System.Windows.Forms.ComboBox();
			this.numericUpDownGaussianFilterWeight = new System.Windows.Forms.NumericUpDown();
			this.buttonSharpening = new System.Windows.Forms.Button();
			this.numericUpDownSharpeningDegree = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownNoise = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxModified)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownGaussianFilterWeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSharpeningDegree)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoise)).BeginInit();
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
            this.ToolStripMenuItemOpenFile,
            this.ToolStripMenuItemSaveAsFile,
            this.ToolStripMenuItemOriginalRecover});
			this.File_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
			this.File_ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.File_ToolStripMenuItem.Text = "Файл";
			// 
			// ToolStripMenuItemOpenFile
			// 
			this.ToolStripMenuItemOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ToolStripMenuItemOpenFile.ForeColor = System.Drawing.Color.White;
			this.ToolStripMenuItemOpenFile.Name = "ToolStripMenuItemOpenFile";
			this.ToolStripMenuItemOpenFile.Size = new System.Drawing.Size(204, 22);
			this.ToolStripMenuItemOpenFile.Text = "Открыть";
			this.ToolStripMenuItemOpenFile.Click += new System.EventHandler(this.ToolStripMenuItemOpenFileClick);
			// 
			// ToolStripMenuItemSaveAsFile
			// 
			this.ToolStripMenuItemSaveAsFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ToolStripMenuItemSaveAsFile.ForeColor = System.Drawing.Color.White;
			this.ToolStripMenuItemSaveAsFile.Name = "ToolStripMenuItemSaveAsFile";
			this.ToolStripMenuItemSaveAsFile.Size = new System.Drawing.Size(204, 22);
			this.ToolStripMenuItemSaveAsFile.Text = "Сохранить как...";
			this.ToolStripMenuItemSaveAsFile.Click += new System.EventHandler(this.ToolStripMenuItemSaveAsFileClick);
			// 
			// ToolStripMenuItemOriginalRecover
			// 
			this.ToolStripMenuItemOriginalRecover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ToolStripMenuItemOriginalRecover.ForeColor = System.Drawing.Color.White;
			this.ToolStripMenuItemOriginalRecover.Name = "ToolStripMenuItemOriginalRecover";
			this.ToolStripMenuItemOriginalRecover.Size = new System.Drawing.Size(204, 22);
			this.ToolStripMenuItemOriginalRecover.Text = "Восстановить исходное";
			this.ToolStripMenuItemOriginalRecover.Click += new System.EventHandler(this.ToolStripMenuItemOriginalRecoverClick);
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
			// pictureBoxOriginal
			// 
			this.pictureBoxOriginal.Location = new System.Drawing.Point(12, 48);
			this.pictureBoxOriginal.Name = "pictureBoxOriginal";
			this.pictureBoxOriginal.Size = new System.Drawing.Size(512, 512);
			this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxOriginal.TabIndex = 6;
			this.pictureBoxOriginal.TabStop = false;
			// 
			// pictureBoxModified
			// 
			this.pictureBoxModified.Location = new System.Drawing.Point(530, 48);
			this.pictureBoxModified.Name = "pictureBoxModified";
			this.pictureBoxModified.Size = new System.Drawing.Size(512, 512);
			this.pictureBoxModified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxModified.TabIndex = 7;
			this.pictureBoxModified.TabStop = false;
			// 
			// buttonRememberModified
			// 
			this.buttonRememberModified.Location = new System.Drawing.Point(792, 659);
			this.buttonRememberModified.Name = "buttonRememberModified";
			this.buttonRememberModified.Size = new System.Drawing.Size(250, 30);
			this.buttonRememberModified.TabIndex = 20;
			this.buttonRememberModified.Text = "Запомнить модификацию";
			this.buttonRememberModified.UseVisualStyleBackColor = true;
			this.buttonRememberModified.Click += new System.EventHandler(this.ButtonRememberModifiedClick);
			// 
			// buttonMedianFilter
			// 
			this.buttonMedianFilter.Location = new System.Drawing.Point(12, 622);
			this.buttonMedianFilter.Name = "buttonMedianFilter";
			this.buttonMedianFilter.Size = new System.Drawing.Size(170, 30);
			this.buttonMedianFilter.TabIndex = 21;
			this.buttonMedianFilter.Text = "Медианный фильтр";
			this.buttonMedianFilter.UseVisualStyleBackColor = true;
			this.buttonMedianFilter.Click += new System.EventHandler(this.ButtonMedianFilterClick);
			// 
			// buttonGaussianFilter
			// 
			this.buttonGaussianFilter.Location = new System.Drawing.Point(188, 622);
			this.buttonGaussianFilter.Name = "buttonGaussianFilter";
			this.buttonGaussianFilter.Size = new System.Drawing.Size(170, 30);
			this.buttonGaussianFilter.TabIndex = 23;
			this.buttonGaussianFilter.Text = "Фильтр Гаусса";
			this.buttonGaussianFilter.UseVisualStyleBackColor = true;
			this.buttonGaussianFilter.Click += new System.EventHandler(this.ButtonGaussianFilterClick);
			// 
			// buttonSobelOperator
			// 
			this.buttonSobelOperator.Location = new System.Drawing.Point(488, 622);
			this.buttonSobelOperator.Name = "buttonSobelOperator";
			this.buttonSobelOperator.Size = new System.Drawing.Size(171, 30);
			this.buttonSobelOperator.TabIndex = 24;
			this.buttonSobelOperator.Text = "Собель";
			this.buttonSobelOperator.UseVisualStyleBackColor = true;
			this.buttonSobelOperator.Click += new System.EventHandler(this.ButtonSobelOperatorClick);
			// 
			// comboBoxMedianFilter
			// 
			this.comboBoxMedianFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMedianFilter.Location = new System.Drawing.Point(12, 587);
			this.comboBoxMedianFilter.Name = "comboBoxMedianFilter";
			this.comboBoxMedianFilter.Size = new System.Drawing.Size(90, 29);
			this.comboBoxMedianFilter.TabIndex = 25;
			// 
			// buttonAddNoise
			// 
			this.buttonAddNoise.Location = new System.Drawing.Point(871, 622);
			this.buttonAddNoise.Name = "buttonAddNoise";
			this.buttonAddNoise.Size = new System.Drawing.Size(171, 30);
			this.buttonAddNoise.TabIndex = 26;
			this.buttonAddNoise.Text = "Добавить шум";
			this.buttonAddNoise.UseVisualStyleBackColor = true;
			this.buttonAddNoise.Click += new System.EventHandler(this.ButtonAddNoiseClick);
			// 
			// comboBoxGaussianFilter
			// 
			this.comboBoxGaussianFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGaussianFilter.Location = new System.Drawing.Point(188, 586);
			this.comboBoxGaussianFilter.Name = "comboBoxGaussianFilter";
			this.comboBoxGaussianFilter.Size = new System.Drawing.Size(90, 29);
			this.comboBoxGaussianFilter.TabIndex = 27;
			// 
			// numericUpDownGaussianFilterWeight
			// 
			this.numericUpDownGaussianFilterWeight.DecimalPlaces = 2;
			this.numericUpDownGaussianFilterWeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDownGaussianFilterWeight.Location = new System.Drawing.Point(289, 587);
			this.numericUpDownGaussianFilterWeight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownGaussianFilterWeight.Name = "numericUpDownGaussianFilterWeight";
			this.numericUpDownGaussianFilterWeight.Size = new System.Drawing.Size(69, 29);
			this.numericUpDownGaussianFilterWeight.TabIndex = 28;
			this.numericUpDownGaussianFilterWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// buttonSharpening
			// 
			this.buttonSharpening.Location = new System.Drawing.Point(665, 622);
			this.buttonSharpening.Name = "buttonSharpening";
			this.buttonSharpening.Size = new System.Drawing.Size(200, 30);
			this.buttonSharpening.TabIndex = 29;
			this.buttonSharpening.Text = "Повышение резкости";
			this.buttonSharpening.UseVisualStyleBackColor = true;
			this.buttonSharpening.Click += new System.EventHandler(this.ButtonSharpeningClick);
			// 
			// numericUpDownSharpeningDegree
			// 
			this.numericUpDownSharpeningDegree.DecimalPlaces = 2;
			this.numericUpDownSharpeningDegree.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.numericUpDownSharpeningDegree.Location = new System.Drawing.Point(665, 590);
			this.numericUpDownSharpeningDegree.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownSharpeningDegree.Name = "numericUpDownSharpeningDegree";
			this.numericUpDownSharpeningDegree.Size = new System.Drawing.Size(69, 29);
			this.numericUpDownSharpeningDegree.TabIndex = 30;
			this.numericUpDownSharpeningDegree.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDownNoise
			// 
			this.numericUpDownNoise.Location = new System.Drawing.Point(871, 590);
			this.numericUpDownNoise.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownNoise.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownNoise.Name = "numericUpDownNoise";
			this.numericUpDownNoise.Size = new System.Drawing.Size(69, 29);
			this.numericUpDownNoise.TabIndex = 31;
			this.numericUpDownNoise.Value = new decimal(new int[] {
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
			this.Controls.Add(this.numericUpDownNoise);
			this.Controls.Add(this.numericUpDownSharpeningDegree);
			this.Controls.Add(this.buttonSharpening);
			this.Controls.Add(this.numericUpDownGaussianFilterWeight);
			this.Controls.Add(this.comboBoxGaussianFilter);
			this.Controls.Add(this.buttonAddNoise);
			this.Controls.Add(this.comboBoxMedianFilter);
			this.Controls.Add(this.buttonSobelOperator);
			this.Controls.Add(this.buttonGaussianFilter);
			this.Controls.Add(this.buttonMedianFilter);
			this.Controls.Add(this.buttonRememberModified);
			this.Controls.Add(this.pictureBoxModified);
			this.Controls.Add(this.pictureBoxOriginal);
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxModified)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownGaussianFilterWeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSharpeningDegree)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoise)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpenFile;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveAsFile;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOriginalRecover;
		private System.Windows.Forms.Label label_original_image;
		private System.Windows.Forms.Label label_modified_image;
		private System.Windows.Forms.PictureBox pictureBoxOriginal;
		private System.Windows.Forms.PictureBox pictureBoxModified;
		private System.Windows.Forms.Button buttonRememberModified;
		private System.Windows.Forms.Button buttonMedianFilter;
		private System.Windows.Forms.Button buttonGaussianFilter;
		private System.Windows.Forms.Button buttonSobelOperator;
		private System.Windows.Forms.ComboBox comboBoxMedianFilter;
		private System.Windows.Forms.Button buttonAddNoise;
		private System.Windows.Forms.ComboBox comboBoxGaussianFilter;
		private System.Windows.Forms.NumericUpDown numericUpDownGaussianFilterWeight;
		private System.Windows.Forms.Button buttonSharpening;
		private System.Windows.Forms.NumericUpDown numericUpDownSharpeningDegree;
		private System.Windows.Forms.NumericUpDown numericUpDownNoise;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}

