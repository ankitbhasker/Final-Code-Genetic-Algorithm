using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Steganography
{
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }
        private Bitmap bmp = null;
        public Image enc = null;
        Bitmap NormalizeLbpMatrix(double[,] Mat, Bitmap lbp, double max)
        {
            int NumRow = lbp.Height;
            int numCol = lbp.Width;
            for (int i = 0; i < NumRow; i++)
            {
                for (int j = 0; j < numCol; j++)
                {
                    // see the Normalization process of dividing pixel by max value and multiplying with 255
                    double d = Mat[j, i] / max;
                    int v = (int)(d * 255);
                    Color c = Color.FromArgb(v, v, v);
                    lbp.SetPixel(j, i, c);
                }
            }
            return lbp;
        }
        void Resize()
        {
            Bitmap bmp = new Bitmap(pictureBox2.Image, new Size(pictureBox2.Width, pictureBox2.Height)); pictureBox2.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1. Open a file open browser and ask user for entering an Image
            // The region to be inpainted must be colored with Red in Paint
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName == null)
                return;
            pictureBox2.Image = Bitmap.FromFile(ofd.FileName);
            // The image may of of any size. resize it to fit picturebox1. We have used 256x256 standard size
            Resize();
            // Obtain mask from source image

        }

       
        public Image OverlayImage(Image baseImage, Image topImage, float transparency)
        {
            System.Drawing.Imaging.ImageAttributes ia = new System.Drawing.Imaging.ImageAttributes();
            System.Drawing.Imaging.ColorMatrix cm = new System.Drawing.Imaging.ColorMatrix();
            cm.Matrix33 = transparency;
            ia.SetColorMatrix(cm);
            Graphics g = null;
            try
            {
                g = Graphics.FromImage(baseImage);
                Rectangle rect = new Rectangle((int)(topImage.Width * 0.1), (int)(topImage.Height * 0.2), (int)(topImage.Width * 0.8), (int)(topImage.Height * 0.6));
                // YOU MAY DEFINE THE RECT AS THIS AS WELL
                //Rectangle rect = new Rectangle(0, 0, baseImage.Width,      baseImage.Height, baseImage.Width);
                g.DrawImage(topImage, rect, 0, 0, topImage.Width, topImage.Height, GraphicsUnit.Pixel, ia);
                return baseImage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                g.Dispose();
                topImage.Dispose();
            }

        }

       
        private void button6_Click(object sender, EventArgs e)
        {
            //1. Open a file open browser and ask user for entering an Image
            // The region to be inpainted must be colored with Red in Paint
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName == null)
                return;
            pictureBox4.Image = Bitmap.FromFile(ofd.FileName);
            // The image may of of any size. resize it to fit picturebox1. We have used 256x256 standard size
            Bitmap bmp = new Bitmap(pictureBox4.Image, new Size(pictureBox4.Width, pictureBox4.Height));
            pictureBox3.Image = bmp;
            // Obtain mask from source image
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = OverlayImage(pictureBox2.Image, pictureBox4.Image, 0.4f);
            enc = pictureBox3.Image;
            
        }
        string str;
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|PNG files (*.png)|*.png|TIF files (*.tif)|*.tif|All files (*.*)|*.*";
            save.FilterIndex = 2;
            save.RestoreDirectory = true;
            save.OverwritePrompt = true;
            save.ShowHelp = true;
            save.AddExtension = true;

            if ((save.ShowDialog() == DialogResult.OK))
            {
                if (Path.GetExtension(save.FileName).ToLower() == ".bmp")
                    pictureBox3.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                else if (Path.GetExtension(save.FileName).ToLower() == ".jpg")
                    pictureBox3.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                else if (Path.GetExtension(save.FileName).ToLower() == ".gif")
                    pictureBox3.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                else if (Path.GetExtension(save.FileName).ToLower() == ".png")
                    pictureBox3.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Png);
                else if (Path.GetExtension(save.FileName).ToLower() == ".tif")
                    pictureBox3.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Tiff);
                MessageBox.Show("Image Saved Successfully");
                FormMain frm = new FormMain();
                frm.Show();
                this.Hide();
                
            }
            else
            {

                MessageBox.Show("File Save Error.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void UserHome_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
