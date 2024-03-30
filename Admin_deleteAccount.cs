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
    public partial class Admin_deleteAccount : Form
    {
        Account account = new Account();

        public Admin_deleteAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accountNo = textBox1.Text;
            int userID = Convert.ToInt32(textBox4.Text);
            string status = account.getStatus(accountNo);
            if (status == "Deactivate")
            {
                if (account.activateAccount(accountNo) > 0)
                {
                    MessageBox.Show("Account Activated");
                }

            }
            else if (status == "Activate")
            {
                if (account.deactivateAccount(accountNo) > 0)
                {
                    MessageBox.Show("Account Deactivated");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Homepage home = new Admin_Homepage();
            home.Show();
            this.Hide();
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
