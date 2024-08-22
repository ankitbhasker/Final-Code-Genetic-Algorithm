using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Steganography
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\ProImages\";

           // string appPath =@"\D\Image\"; // <---
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }                                                                                    // <---

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = opFile.SafeFileName;   // <---
                    string filepath = opFile.FileName;    // <---
                    File.Copy(filepath, appPath + iName); // <---
                    pictureBox1.Image = new Bitmap(opFile.OpenFile());
                   pictureBox1.Image.Save(Application.StartupPath + "\\Image\\picture1.jpg");


                  //  if (System.IO.File.Exists("D:\\anuu.jpg"))
                  //      System.IO.File.Delete("D:\\anuu.jpg");
                  //pictureBox1.Image=  Image.FromFile("D:\\anuu.jpg");





                  Bitmap bmp1 = new Bitmap(pictureBox1.Image);

                  if (System.IO.File.Exists("c:\\t.jpg"))
                      System.IO.File.Delete("c:\\t.jpg");

                  bmp1.Save("c:\\t.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                  // Dispose of the image files.
                  bmp1.Dispose();
    
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test1 ts = new test1();
            ts.Show();
            this.Hide();
        }

        
    }
}
