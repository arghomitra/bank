using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_project
{
    public partial class create : Form
    {
        private int borderRadius = 70;
        User user = new User(); // Create a User object
        Account account = new Account();


        public create()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            string email = textBox1.Text;

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
                login login = new login();
                login.Show();
                this.Hide();
            }
            else
            {
                label7.Text = "already exist";
            }



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
