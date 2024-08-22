using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Diagnostics;

namespace Steganography
{
    public partial class FormMain : Form
    {
        
        private const int GENERATE_IMAGE_COUNT = 2;

        private Bitmap[] m_EncryptedImages;
        Stopwatch timer = new Stopwatch();
        public static String seckey;

        public FormMain()
        {
            InitializeComponent();
            buttonGenerate.Visible = true;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text != "")
            {
               

                if (m_EncryptedImages != null)
                {
                    for (int i = m_EncryptedImages.Length - 1; i > 0; i--)
                    {
                        m_EncryptedImages[i].Dispose();
                    }
                    Array.Clear(m_EncryptedImages, 0, m_EncryptedImages.Length);
                }
               
                using (Bitmap temp = Bitmap.FromFile(textBoxInput.Text) as Bitmap)
                {
                    using (Bitmap source = new Bitmap(temp.Width, temp.Height))
                    {
                        using (Graphics g = Graphics.FromImage(source))
                        {
                            g.DrawImage(temp, 0, 0);
                            List<Color> palette = new List<Color>();
                            palette.Add(Color.FromArgb(0, 0, 0));
                            palette.Add(Color.FromArgb(190, 190, 190));
                            using (Bitmap gSource = ConvertToGrayscale(source))
                            {
                                using (Bitmap bwSource = GeneticAl.Process(gSource, palette.ToArray()))
                                {
                                    m_EncryptedImages = GenerateImage(bwSource);
                                }
                            }
                        }
                    }
                }
                panelCanvas.Invalidate();
                timer.Stop();
                label3.Text = "Encryption Time:" + timer.Elapsed;
            }
        }

        public Bitmap ConvertToGrayscale(Bitmap source)
        {
            int sourceWidth = source.Width;
            int sourceHeight = source.Height;
            Bitmap result = new Bitmap(sourceWidth, sourceHeight);
            for (int y = 0; y < sourceHeight; y++)
            {
                for (int x = 0; x < sourceWidth; x++)
                {
                    Color c = source.GetPixel(x, y);
                    int luma = (int)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);
                    result.SetPixel(x, y, Color.FromArgb(luma, luma, luma));
                }
            }
            return result;
        }

        private Bitmap ConvertToBackAndWhite(Bitmap source)
        {
            int sourceWidth = source.Width;
            int sourceHeight = source.Height;

            Bitmap result = new Bitmap(sourceWidth, sourceHeight);
            double mid = 190 * (1d / 2d);

            for (int x = 0; x < sourceWidth; x++)
            {
                for (int y = 0; y < sourceHeight; y++)
                {
                    Color c = source.GetPixel(x, y);
                    c = (Average(c.R, c.G, c.B) > mid) ? Color.Empty : Color.Black;
                    result.SetPixel(x, y, c);
                }
            }

            return result;
        }

        private Bitmap[] GenerateImage(Bitmap source)
        {
            int sourceWidth = source.Width;
            int sourceHeight = source.Height;

            Bitmap tempImage = new Bitmap(sourceWidth / 2, sourceHeight);
            Bitmap[] image = new Bitmap[GENERATE_IMAGE_COUNT];
            
            Random rand = new Random();
            timer.Start();
            SolidBrush brush = new SolidBrush(Color.Black);
            Point mid = new Point(sourceWidth / 2, sourceHeight / 2);

            Graphics gtemp = Graphics.FromImage(tempImage);

            Color foreColor;

            gtemp.DrawImage(source, 0, 0, tempImage.Width, tempImage.Height);


            for (int i = 0; i < image.Length; i++)
            {
                image[i] = new Bitmap(sourceWidth, sourceHeight);
            }

            
            int index = -1;
            int width = tempImage.Width;
            int height = tempImage.Height;
            for (int x = 0; x < width; x += 1)
            {
                for (int y = 0; y < height; y += 1)
                {
                    foreColor = tempImage.GetPixel(x, y);
                    index = rand.Next(image.Length);
                    if (foreColor.ToArgb() == Color.Empty.ToArgb() || foreColor.ToArgb() == Color.White.ToArgb())
                    {
                        for (int i = 0; i < image.Length; i++)
                        {
                            if (index == 0)
                            {
                                image[i].SetPixel(x * 2, y, Color.Black);
                                image[i].SetPixel(x * 2 + 1, y, Color.Empty);
                            }
                            else
                            {
                                image[i].SetPixel(x * 2, y, Color.Empty);
                                image[i].SetPixel(x * 2 + 1, y, Color.Black);
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < image.Length; i++)
                        {
                            if ((index + i) % image.Length == 0)
                            {
                                image[i].SetPixel(x * 2, y, Color.Black);
                                image[i].SetPixel(x * 2 + 1, y, Color.Empty);
                            }
                            else
                            {
                                image[i].SetPixel(x * 2, y, Color.Empty);
                                image[i].SetPixel(x * 2 + 1, y, Color.Black);
                            }
                        }
                    }
                }
            }

            brush.Dispose();
            tempImage.Dispose();

            return image;
        }

        private double Average(params int[] inputList)
        {
            double total = 0;
            foreach (var num in inputList)
            {
                total += num;
            }

            return total / inputList.Length;
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_EncryptedImages == null)
            {
                MessageBox.Show("Please generate image first", this.Text);
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(saveFileDialog1.FileName);
                string filePath = saveFileDialog1.FileName;
                string savePath = fileName;
                for (int i = 0; i < m_EncryptedImages.Length; i++)
                {
                    savePath = filePath.Replace(fileName, fileName + i);
                    m_EncryptedImages[i].Save(savePath, ImageFormat.Png);
                }
            }
        }

        private void textBoxInput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxInput.Text = openFileDialog1.FileName;
            }
            pictureBox1.Image = Image.FromFile(textBoxInput.Text);
            MessageBox.Show("Enter Secret Key First");
            SecKeytxt.Visible = true;
            SecKeyLbl.Visible = true;

        }
        
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecKeytxt_Enter(object sender, EventArgs e)
        {
           
        }
        string pagAtual;
        private void button1_Click(object sender, EventArgs e)
        {
            int width = panelCanvas .Size.Width;
            int height = panelCanvas .Size.Height;

            using (Bitmap bmp = new Bitmap(width, height))
            {
                panelCanvas .DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(@"E:\SecretKey.jpeg", ImageFormat.Jpeg);
            }
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

            //SaveFileDialog save = new SaveFileDialog();
            //save.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|PNG files (*.png)|*.png|TIF files (*.tif)|*.tif|All files (*.*)|*.*";
            //save.FilterIndex = 2;
            //save.RestoreDirectory = true;
            //save.OverwritePrompt = true;
            //save.ShowHelp = true;
            //save.AddExtension = true;
            
            //if ((save.ShowDialog() == DialogResult.OK))
            //{
            //    using (Bitmap bitmap = new Bitmap(panelCanvas.ClientSize.Width,panelCanvas.ClientSize.Height))
            //    {
            //        panelCanvas .DrawToBitmap(bitmap, panelCanvas .ClientRectangle);
            //        bitmap.Save("C:\\" + pagAtual + ".bmp", ImageFormat.Bmp);
            //    }
            //    MessageBox.Show("Image Saved Successfully");
            //    //FormMain frm = new FormMain();
            //    //frm.Show();
            //    //this.Hide();
                
            //}
            //else
            //{

            //    MessageBox.Show("File Save Error.");
            //}
        }

        private void panelCanvas_Paint_1(object sender, PaintEventArgs e)
        {
            if (m_EncryptedImages != null)
            {
                Graphics g = e.Graphics;
                Rectangle rect = new Rectangle(0, 0, 0, 0);
                for (int i = 0; i < m_EncryptedImages.Length; i++)
                {
                    rect.Size = m_EncryptedImages[i].Size;
                    g.DrawImage(m_EncryptedImages[i], rect);
                    rect.Y += m_EncryptedImages[i].Height + 5;
                }

                g.DrawLine(new Pen(new SolidBrush(Color.Black), 1), rect.Location, new Point(rect.Width, rect.Y));
                rect.Y += 5;

                for (int i = 0; i < m_EncryptedImages.Length; i++)
                {
                    rect.Size = m_EncryptedImages[i].Size;
                    g.DrawImage(m_EncryptedImages[i], rect);
                }
            }
        }

        private void SecKeytxt_Validating(object sender, CancelEventArgs e)
        {
           
            seckey = SecKeytxt.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}