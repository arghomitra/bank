using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bank_project
{
    public partial class Deposit : Form
    {
        Data database = new Data();

        User user = new User();
        Account account = new Account();


        public Deposit()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            user.Email = login.email;
            string email = login.email;
            user = user.GetID(user);

            string accountNo = textBox1.Text;
            string password = textBox4.Text;

            if (user.Verify(email, password) == 200)
            {

                Decimal Balance = Convert.ToDecimal(textBox2.Text);

                Decimal previousBalance = account.GetBalanceByAccount(accountNo);

                Decimal newBalance = previousBalance + Balance;

                if (account.UpdateBalance(newBalance, accountNo) > 0)
                {
                    MessageBox.Show("Deposit completed");
                }

                Home_page home = new Home_page();
                home.Show();
                this.Hide();
            }
            else
            {
                label6.Text = "wrong  password";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home_page home = new Home_page();
            home.Show();
            this.Hide();
        }
    }
}
