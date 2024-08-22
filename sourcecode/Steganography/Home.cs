using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Steganography
{
    public partial class Home : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ETPLK3;Initial Catalog=Stegnography;Integrated Security=True");
        public Home()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand com = new SqlCommand("select * from Register where Name = '" + textBox1.Text + "' and Pass='" + textBox2.Text + "' ", con);
                SqlDataAdapter ad = new SqlDataAdapter(com);
                
                MessageBox.Show("Welcome ", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UserHome uh = new UserHome();
                uh.Show();
                this.Hide();

                

            }

            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Failed To Login!");
            }
        }

        private void NewLogin_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
