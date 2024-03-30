using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_project
{
    public partial class Admin_createAccount : Form
    {
        Account account = new Account();
        Admin admin = new Admin();
        public Admin_createAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int userID = Convert.ToInt32(textBox3.Text);
            string AccountNo = textBox1.Text;
            Decimal balance = Convert.ToDecimal(textBox2.Text);

            try
            {
                if (admin.insertaccountByAdmin(AccountNo, userID, balance) > 0)
                {
                    MessageBox.Show("Account Created");

                }
                MessageBox.Show("Account Created");
                Admin_Homepage home = new Admin_Homepage();
                home.Show();
                this.Hide();

            }
            catch(Exception)
            {
                MessageBox.Show("User id not found.");

            }



        }

        private void Admin_createAccount_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(100000000, 999999999);
            textBox1.Text = randomNumber.ToString();
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
