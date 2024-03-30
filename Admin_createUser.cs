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
    public partial class Admin_createUser : Form
    {
        User user = new User();
        Account Account = new Account();

        public Admin_createUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string email = textBox6.Text;

            if (user.findUser(email) == 0)
            {
                user.First_name = textBox1.Text;
                user.Last_name = textBox8.Text;
                user.Email = textBox6.Text;
                user.Password = textBox7.Text;

                if (user.InsertUser(user) > 0)
                {
                    MessageBox.Show("üser created");
                };
                Admin_Homepage homepage = new Admin_Homepage();
                homepage.Show();
                this.Hide();
            }
            else
            {
                label7.Text = "already exist";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Homepage homepage = new Admin_Homepage();
            homepage.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
