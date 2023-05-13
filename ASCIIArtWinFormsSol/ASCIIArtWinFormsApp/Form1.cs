using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace ASCIIArtWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var formatName in AsciiArtCreator.Formats.Keys)
            {
                artFormatsComboBox.Items.Add(formatName);
            }
            artFormatsComboBox.SelectedIndex = 0;
        }

        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                originalPictureBox.Image = Bitmap.FromFile(openFileDialog1.FileName);
            }
        }

        private void startCreationToolButton_Click(object sender, EventArgs e)
        {
            if (originalPictureBox.Image == null || backgroundWorker1.IsBusy)
                return;
            richTextBox1.Clear();
            backgroundWorker1.RunWorkerAsync(widthImaheUpDown.Value);
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Int32.TryParse(e.Argument.ToString(), out int res))
            {
                Bitmap[] bitmaps = new Bitmap[2];
                bitmaps[0] = ImageChanger.ResizePicture(originalPictureBox.Image, res);
                backgroundWorker1.ReportProgress(50);
                bitmaps[1] = ImageChanger.BlackAndWhiteCreator(bitmaps[0]);
                backgroundWorker1.ReportProgress(100);
                richTextBox1.Text = AsciiArtCreator.MakeArt(bitmaps[1]);
                e.Result = bitmaps;
            }   
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Bitmap[] bitmaps = e.Result as Bitmap[];
            if (bitmaps == null)
            {
                MessageBox.Show("Ïðåîáðàçîâàíèå íå óäàëîñü");
                return;
            }
            scaledPictureBox.Image = bitmaps[0];
            blackAndWhitePictureBox.Image = bitmaps[1];
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
                if (fileInfo.Extension == "bmp" || fileInfo.Extension == "png" || fileInfo.Extension == "jpeg")
                    originalPictureBox.Image = Bitmap.FromFile(files[0]);
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = trackBar1.Value * 0.01f;
        }

        private void artFormatsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AsciiArtCreator.ArtFormat = artFormatsComboBox.Items[artFormatsComboBox.SelectedIndex].ToString();
        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ñîõðàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || richTextBox1.Text == null)
                return;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.WriteLineAsync(richTextBox1.Text);
                writer.Close();
                writer.Dispose();
                fileStream.Close();
                fileStream.Dispose();
            }
        }

        private void êîïèðîâàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void âûáðàòüâñåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
    }
}