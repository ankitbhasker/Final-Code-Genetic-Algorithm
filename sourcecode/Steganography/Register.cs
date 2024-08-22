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
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ETPLK3;Initial Catalog=Stegnography;Integrated Security=True");
        public Register()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Register(Name,Password,Designation,Address,Contact) values('" + Doname.Text + "','" + Password.Text + "','" +Designation.Text+ "','" + Address.Text + "','" + Contact.Text + "')", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            MessageBox.Show("Registered Successfully" + '"' + Doname.Text + '"');
            Home hm = new Home();
            hm.Show();
            this.Hide();
            
        }

       
    }
}
