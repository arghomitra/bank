using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bank_project
{
    public partial class editProfile : Form
    {
        User user = new User();
        public editProfile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void editProfile_Load(object sender, EventArgs e)
        {
            user.Email = login.email;

            user = user.GetID(user);

            textBox1.Text = user.First_name;
            textBox2.Text = user.Last_name;
            textBox3.Text = user.Email;
            textBox4.Text = user.Password;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = user.First_name;
            textBox2.Text = user.Last_name;
            textBox3.Text = user.Email;
            textBox4.Text = user.Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home_page home = new Home_page();
            home.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty && textBox3.Text == string.Empty && textBox4.Text == string.Empty)
            {
                MessageBox.Show("Field Empty");
            }
            else
            {
                if (user.findUser(textBox3.Text) == 0 || user.Email == textBox3.Text)
                {
                    user.First_name = textBox1.Text;
                    user.Last_name = textBox2.Text;
                    user.Email = textBox3.Text;
                    user.Password = textBox4.Text;

                    if (user.Update(user) > 0)
                    {
                        MessageBox.Show("done");
                        login login = new login();
                        login.Show();
                        this.Hide();
                    }

                }
                else
                {

                    MessageBox.Show("Email already Exists");
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home_page home = new Home_page();
            home.Show();
            this.Hide();

        }
    }
}
