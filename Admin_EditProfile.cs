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
    public partial class Admin_EditProfile : Form
    {
        User user = new User();
        Admin admin = new Admin();
        public Admin_EditProfile()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty && textBox3.Text == string.Empty && textBox4.Text == string.Empty)
            {
                MessageBox.Show("Field Empty");
            }
            else
            {
                int userID = Convert.ToInt32(textBox5.Text);
                string firstName = textBox1.Text;
                string lastName = textBox2.Text;
                string email = textBox3.Text;
                string password = textBox4.Text;

                if (admin.UpdateByAdmin(userID, firstName, lastName, email, password) > 0)
                {
                    MessageBox.Show("Edit Complete");
                    Admin_Homepage home = new Admin_Homepage();
                    home.Show();
                    this.Hide();
                }


                else
                {

                    MessageBox.Show("Email already Exists");
                }
            }
        }

        private void Admin_EditProfile_Load(object sender, EventArgs e)
        {


            //string Email = admin.Email;

            //user = admin.(user);

            //textBox1.Text = user.First_name;
            //textBox2.Text = user.Last_name;
            //textBox3.Text = user.Email;
            //textBox4.Text = user.Password;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int userID = Convert.ToInt32(textBox5.Text);
            //textBox1.Text = user.First_name;
            //textBox2.Text = user.Last_name;
            //textBox3.Text = user.Email;
            //textBox4.Text = user.Password;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Homepage homepage = new Admin_Homepage();
            homepage.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Homepage homepage = new Admin_Homepage();
            homepage.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox5.Text);
            user = user.GetUser(id);

            textBox1.Text = user.First_name;
            textBox2.Text = user.Last_name;
            textBox3.Text = user.Email;
            textBox4.Text = user.Password;

        }
    }
}

