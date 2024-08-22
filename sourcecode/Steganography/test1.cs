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
    public partial class test1 : Form
    {
        string pic = "gandhi.jpg";
        public test1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(@"\D\Images\gandhi.jpg");
         //  pictureBox1.Image.Save(Application.StartupPath + "D\\Image\\gandhi.jpg");

            FileStream fs = new System.IO.FileStream("ProImages\\" + pic, FileMode.Open, FileAccess.Read);
            pictureBox1.Image = Image.FromStream(fs);
            fs.Close();
        }
    }
}
