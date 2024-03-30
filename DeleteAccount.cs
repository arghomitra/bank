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
    public partial class DeleteAccount : Form
    {
        User user = new User();

        Data database = new Data();
        Account account = new Account();

        public DeleteAccount()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteAccount_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accountNo = textBox1.Text;
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
            Home_page home = new Home_page();
            home.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
