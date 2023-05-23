using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace ASCIIArtCreatorDotNetFramework
{
    public partial class Form1 : Form
    {
        delegate Bitmap ImageChangerDelegate(Image image, bool invert);
        delegate string ImageArtDelegate(Image image);
        ImageChangerDelegate imageChangersMethods;
        ImageArtDelegate imageArtMethods;
        public Form1()
        {
            InitializeComponent();
            foreach (var formatName in AsciiArtCreator.Formats.Keys)
            {
                artFormatsComboBox.Items.Add(formatName);
            }
            artFormatsComboBox.SelectedIndex = AsciiArtCreator.Formats.Count - 2;
            zoomLabel.Text = $"{richTextBox1.Font.Size} pt";
            imageChangersMethods = ImageChanger.BlackAndWhiteCreator;
            imageArtMethods = AsciiArtCreator.MakeArt;
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    originalPictureBox.Image = Bitmap.FromFile(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка {ex.Message}", "Ошибка");
                }
            }
        }

        private void startCreationToolButton_Click(object sender, EventArgs e)
        {
            if (originalPictureBox.Image == null || backgroundWorker1.IsBusy)
                return;
            richTextBox1.Clear();
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 12f);
            toolStripProgressBar1.Value = 0;
            trackBar1.Value = 12;
            zoomLabel.Text = $"{richTextBox1.Font.Size} pt";
            backgroundWorker1.RunWorkerAsync(new Size(((int)widthImaheUpDown.Value), 
                heightUpDown.Enabled ? ((int)heightUpDown.Value) : 0));
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Argument is Size size)
            {
                Bitmap[] bitmaps = new Bitmap[2];
                bitmaps[0] = ImageChanger.ResizePicture(originalPictureBox.Image, size.Width, size.Height);
                backgroundWorker1.ReportProgress(25);
                bitmaps[1] = imageChangersMethods(bitmaps[0], invertColorsCheckBox.Checked);
                backgroundWorker1.ReportProgress(50);
                string art = "";
                art = imageArtMethods(bitmaps[1]);
                backgroundWorker1.ReportProgress(100);
                ArrayList arrayList = new ArrayList()
                {
                    bitmaps, art
                };
                e.Result = arrayList;
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ArrayList arrayList = e.Result as ArrayList;
            if (arrayList == null)
                return;
            Bitmap[] bitmaps = null;
            string art = null;
            for (int i = 0; i < arrayList.Count; i++)
            {
                if (arrayList[i] is Bitmap[])
                    bitmaps = arrayList[i] as Bitmap[];
                else if (arrayList[i] is string)
                    art = arrayList[i] as string;
            }
            if (bitmaps == null || art == null)
            {
                MessageBox.Show("Преобразование не удалось");
                return;
            }
            scaledPictureBox.Image = bitmaps[0];
            blackAndWhitePictureBox.Image = bitmaps[1];
            richTextBox1.Text = art;
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                FileInfo fileInfo = new FileInfo(files[0]);
                if (fileInfo.Extension == ".bmp" || fileInfo.Extension == ".png" || fileInfo.Extension == ".jpeg" || fileInfo.Extension == ".jpg")
                    originalPictureBox.Image = Bitmap.FromFile(files[0]);
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, trackBar1.Value);
            zoomLabel.Text = $"{richTextBox1.Font.Size} pt";
        }

        private void artFormatsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AsciiArtCreator.ArtFormat = artFormatsComboBox.Items[artFormatsComboBox.SelectedIndex].ToString();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || richTextBox1.Text == null)
                return;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(fileStream);
                await  writer.WriteAsync(richTextBox1.Text);
                SystemSounds.Beep.Play();
                writer.Close();
                writer.Dispose();
                fileStream.Close();
                fileStream.Dispose();
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void выбратьвсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void coolArtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (coolArtCheckBox.Checked)
            {
                artFormatsComboBox.Enabled = false;
                imageChangersMethods = ImageChanger.GetMonochromeBitmap;
                imageArtMethods = ExtraAsciiArtCreator.GetArt;
            }
            else
            {
                artFormatsComboBox.Enabled = true;
                imageChangersMethods = ImageChanger.BlackAndWhiteCreator;
                imageArtMethods = AsciiArtCreator.MakeArt;
            }
            if (autoSizeCheckBox.Checked)
            {
                heightUpDown.Enabled = false;
            }
            else
            {
                heightUpDown.Enabled = true;
            }
        }

        private void heightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ((char)Keys.Back) || e.KeyChar == ((char)Keys.Enter))
            {
                TextBox textBox = sender as TextBox;
                if (textBox != null && e.KeyChar == ((char)Keys.Enter))
                {
                    decimal value = decimal.Parse(textBox.Text);
                    if (textBox == heightTextBox)
                    {
                        if (heightUpDown.Minimum <= value && value <= heightUpDown.Maximum)
                            heightUpDown.Value = value;
                    }
                    else if (textBox == widthTextBox)
                    {
                        if (widthImaheUpDown.Minimum <= value && value <= widthImaheUpDown.Maximum)
                            widthImaheUpDown.Value = value;
                    }
                }
            }
            else
                e.Handled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

    }
}
