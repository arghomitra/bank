using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_project
{
    public partial class Admin_login : Form
    {
        Admin admin = new Admin();
        public static string email;
        public Admin_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            email = textBox1.Text;
            string password = textBox2.Text;
            if (admin.Verify(email, password) == 200)
            {
                Admin_Homepage homepage = new Admin_Homepage();
                homepage.Show();
                this.Hide();
            }
            else
            {
                label3.Text = "wrong email or password";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
