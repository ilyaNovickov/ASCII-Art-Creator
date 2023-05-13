using ASCIIArtWinFormsApp_dotNet_Framework_.Properties;
using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASCIIArtWinFormsApp_dotNet_Framework_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.выбратьвсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.открытьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.копироватьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.startCreationToolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.scaledPictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.blackAndWhitePictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.invertColorsCheckBox = new System.Windows.Forms.CheckBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.coolArtCheckBox = new System.Windows.Forms.CheckBox();
            this.autoSizeCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.widthImaheUpDown = new System.Windows.Forms.NumericUpDown();
            this.artFormatsComboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaledPictureBox)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blackAndWhitePictureBox)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthImaheUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.открытьToolStripMenuItem.Text = "&Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.сохранитьToolStripMenuItem.Text = "&Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.выходToolStripMenuItem.Text = "Вы&ход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.toolStripSeparator4,
            this.выбратьвсеToolStripMenuItem});
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(92, 26);
            this.изменитьToolStripMenuItem.Text = "&Изменить";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.копироватьToolStripMenuItem.Text = "&Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(228, 6);
            // 
            // выбратьвсеToolStripMenuItem
            // 
            this.выбратьвсеToolStripMenuItem.Name = "выбратьвсеToolStripMenuItem";
            this.выбратьвсеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.выбратьвсеToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.выбратьвсеToolStripMenuItem.Text = "Выбрать &все";
            this.выбратьвсеToolStripMenuItem.Click += new System.EventHandler(this.выбратьвсеToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripButton,
            this.сохранитьToolStripButton,
            this.toolStripSeparator5,
            this.копироватьToolStripButton,
            this.toolStripSeparator6,
            this.startCreationToolButton,
            this.toolStripSeparator7,
            this.toolStripProgressBar1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // открытьToolStripButton
            // 
            this.открытьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.открытьToolStripButton.Image = global::ASCIIArtWinFormsApp_dotNet_Framework_.Properties.Resources.открытьToolStripButton_Image;
            this.открытьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripButton.Name = "открытьToolStripButton";
            this.открытьToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.открытьToolStripButton.Text = "&Открыть";
            this.открытьToolStripButton.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripButton
            // 
            this.сохранитьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сохранитьToolStripButton.Image = global::ASCIIArtWinFormsApp_dotNet_Framework_.Properties.Resources.сохранитьToolStripButton_Image;
            this.сохранитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            this.сохранитьToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.сохранитьToolStripButton.Text = "&Сохранить";
            this.сохранитьToolStripButton.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // копироватьToolStripButton
            // 
            this.копироватьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.копироватьToolStripButton.Image = global::ASCIIArtWinFormsApp_dotNet_Framework_.Properties.Resources.копироватьToolStripMenuItem_Image;
            this.копироватьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.копироватьToolStripButton.Name = "копироватьToolStripButton";
            this.копироватьToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.копироватьToolStripButton.Text = "&Копировать";
            this.копироватьToolStripButton.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // startCreationToolButton
            // 
            this.startCreationToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startCreationToolButton.Image = global::ASCIIArtWinFormsApp_dotNet_Framework_.Properties.Resources.Start_37108;
            this.startCreationToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startCreationToolButton.Name = "startCreationToolButton";
            this.startCreationToolButton.Size = new System.Drawing.Size(29, 28);
            this.startCreationToolButton.Text = "Старт";
            this.startCreationToolButton.Click += new System.EventHandler(this.startCreationToolButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 28);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 61);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 389);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.originalPictureBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Оригинал";
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.originalPictureBox.Location = new System.Drawing.Point(3, 3);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(786, 356);
            this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.originalPictureBox.TabIndex = 0;
            this.originalPictureBox.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.scaledPictureBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Изображение с изменённым разрешением";
            // 
            // scaledPictureBox
            // 
            this.scaledPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.scaledPictureBox.Location = new System.Drawing.Point(3, 3);
            this.scaledPictureBox.Name = "scaledPictureBox";
            this.scaledPictureBox.Size = new System.Drawing.Size(786, 356);
            this.scaledPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.scaledPictureBox.TabIndex = 0;
            this.scaledPictureBox.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.blackAndWhitePictureBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 362);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Чёрно-белое изображение";
            // 
            // blackAndWhitePictureBox
            // 
            this.blackAndWhitePictureBox.Location = new System.Drawing.Point(3, 3);
            this.blackAndWhitePictureBox.Name = "blackAndWhitePictureBox";
            this.blackAndWhitePictureBox.Size = new System.Drawing.Size(786, 356);
            this.blackAndWhitePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.blackAndWhitePictureBox.TabIndex = 0;
            this.blackAndWhitePictureBox.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.Controls.Add(this.richTextBox1);
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 362);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ASCII Art";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 12F);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(3, 130);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(786, 229);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.invertColorsCheckBox);
            this.panel1.Controls.Add(this.heightTextBox);
            this.panel1.Controls.Add(this.widthTextBox);
            this.panel1.Controls.Add(this.coolArtCheckBox);
            this.panel1.Controls.Add(this.autoSizeCheckBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.heightUpDown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.zoomLabel);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.widthImaheUpDown);
            this.panel1.Controls.Add(this.artFormatsComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 127);
            this.panel1.TabIndex = 1;
            // 
            // invertColorsCheckBox
            // 
            this.invertColorsCheckBox.AutoSize = true;
            this.invertColorsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invertColorsCheckBox.ForeColor = System.Drawing.Color.White;
            this.invertColorsCheckBox.Location = new System.Drawing.Point(240, 61);
            this.invertColorsCheckBox.Name = "invertColorsCheckBox";
            this.invertColorsCheckBox.Size = new System.Drawing.Size(171, 22);
            this.invertColorsCheckBox.TabIndex = 12;
            this.invertColorsCheckBox.Text = "Ивертировать цвета";
            this.toolTip1.SetToolTip(this.invertColorsCheckBox, "Заменяет цвета чёрно-белой картинки на обратные");
            this.invertColorsCheckBox.UseVisualStyleBackColor = true;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(118, 92);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(108, 22);
            this.heightTextBox.TabIndex = 11;
            this.toolTip1.SetToolTip(this.heightTextBox, "Текстовое поле для более удобного ввода размеров картики");
            this.heightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightTextBox_KeyPress);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(4, 92);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(108, 22);
            this.widthTextBox.TabIndex = 10;
            this.toolTip1.SetToolTip(this.widthTextBox, "Текстовое поле для более удобного ввода размеров картики");
            this.widthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightTextBox_KeyPress);
            // 
            // coolArtCheckBox
            // 
            this.coolArtCheckBox.AutoSize = true;
            this.coolArtCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coolArtCheckBox.ForeColor = System.Drawing.Color.White;
            this.coolArtCheckBox.Location = new System.Drawing.Point(240, 33);
            this.coolArtCheckBox.Name = "coolArtCheckBox";
            this.coolArtCheckBox.Size = new System.Drawing.Size(106, 22);
            this.coolArtCheckBox.TabIndex = 9;
            this.coolArtCheckBox.Text = "Крутой арт";
            this.toolTip1.SetToolTip(this.coolArtCheckBox, "Создание крутого ASCII арта\r\nТребует соотношение размеров обрабатываемой картинки" +
        " 2 : 4\r\n\r\n");
            this.coolArtCheckBox.UseVisualStyleBackColor = true;
            this.coolArtCheckBox.CheckedChanged += new System.EventHandler(this.coolArtCheckBox_CheckedChanged);
            // 
            // autoSizeCheckBox
            // 
            this.autoSizeCheckBox.AutoSize = true;
            this.autoSizeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoSizeCheckBox.ForeColor = System.Drawing.Color.White;
            this.autoSizeCheckBox.Location = new System.Drawing.Point(240, 5);
            this.autoSizeCheckBox.Name = "autoSizeCheckBox";
            this.autoSizeCheckBox.Size = new System.Drawing.Size(118, 22);
            this.autoSizeCheckBox.TabIndex = 8;
            this.autoSizeCheckBox.Text = "Авто размер";
            this.toolTip1.SetToolTip(this.autoSizeCheckBox, "Высота преобразуемой картинки определяется автоматически");
            this.autoSizeCheckBox.UseVisualStyleBackColor = true;
            this.autoSizeCheckBox.CheckedChanged += new System.EventHandler(this.coolArtCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Форматы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Высота";
            // 
            // heightUpDown
            // 
            this.heightUpDown.Location = new System.Drawing.Point(118, 61);
            this.heightUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.heightUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(108, 22);
            this.heightUpDown.TabIndex = 5;
            this.heightUpDown.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ширина";
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zoomLabel.ForeColor = System.Drawing.Color.White;
            this.zoomLabel.Location = new System.Drawing.Point(694, 9);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(86, 31);
            this.zoomLabel.TabIndex = 3;
            this.zoomLabel.Text = "label1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(364, 9);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(324, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // widthImaheUpDown
            // 
            this.widthImaheUpDown.Location = new System.Drawing.Point(4, 61);
            this.widthImaheUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.widthImaheUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.widthImaheUpDown.Name = "widthImaheUpDown";
            this.widthImaheUpDown.Size = new System.Drawing.Size(108, 22);
            this.widthImaheUpDown.TabIndex = 1;
            this.widthImaheUpDown.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // artFormatsComboBox
            // 
            this.artFormatsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.artFormatsComboBox.FormattingEnabled = true;
            this.artFormatsComboBox.Location = new System.Drawing.Point(118, 3);
            this.artFormatsComboBox.Name = "artFormatsComboBox";
            this.artFormatsComboBox.Size = new System.Drawing.Size(108, 24);
            this.artFormatsComboBox.TabIndex = 2;
            this.artFormatsComboBox.SelectedIndexChanged += new System.EventHandler(this.artFormatsComboBox_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "bmp files|*.bmp|png files|*.png|jpeg files|*.jpeg;*.jpg";
            this.openFileDialog1.ReadOnlyChecked = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt files|*.txt";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ASCII Art Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaledPictureBox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blackAndWhitePictureBox)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthImaheUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem выбратьвсеToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton открытьToolStripButton;
        private ToolStripButton сохранитьToolStripButton;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton копироватьToolStripButton;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton startCreationToolButton;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripProgressBar toolStripProgressBar1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private OpenFileDialog openFileDialog1;
        private PictureBox originalPictureBox;
        private PictureBox scaledPictureBox;
        private PictureBox blackAndWhitePictureBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RichTextBox richTextBox1;
        private Panel panel1;
        private System.Windows.Forms.ComboBox artFormatsComboBox;
        private NumericUpDown widthImaheUpDown;
        private System.Windows.Forms.TrackBar trackBar1;
        private SaveFileDialog saveFileDialog1;
        private Label zoomLabel;
        private Label label2;
        private NumericUpDown heightUpDown;
        private Label label1;
        private Label label3;
        private CheckBox coolArtCheckBox;
        private CheckBox autoSizeCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private CheckBox invertColorsCheckBox;
    }
}

