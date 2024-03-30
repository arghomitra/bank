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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bank_project
{
    public partial class Transfer : Form
    {
        Data database = new Data();

        User user = new User();
        Account account = new Account();
        public Transfer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home_page home_Page = new Home_page();
            home_Page.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {




            user.Email = login.email;
            string email = login.email;
            user = user.GetID(user);

            string receiverAccount = textBox2.Text;
            string senderAccount = textBox1.Text;
            Decimal amount = Convert.ToDecimal(textBox3.Text);


            string password = textBox4.Text;

            if (user.Verify(email, password) == 200)
            {
                Decimal previousReceiverBalance = account.GetBalanceByAccount(receiverAccount);
                Decimal previousSenderBalance = account.GetBalanceByAccount(senderAccount);
                if (previousSenderBalance >= amount)
                {


                    Decimal receiverNewBalance = previousReceiverBalance + amount;
                    Decimal senderNewBalance = previousSenderBalance - amount;

                    DateTime currentDate = DateTime.Now;
                    string date = currentDate.ToString("yyyy-MM-dd");

                    if (account.UpdateBalance(receiverNewBalance, receiverAccount) > 0)
                    {
                        if (account.UpdateBalance(senderNewBalance, senderAccount) > 0)
                        {
                            MessageBox.Show("Transaction completed");
                        }

                    }
                    if (account.insertTransaction(user.ID, senderAccount, receiverAccount, date, amount) > 0)
                    {
                        MessageBox.Show("Balance updated.");
                    }
                    Home_page home = new Home_page();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Insufficient Balance.");
                }

            }
            else
            {
                label6.Text = "wrong password.";
            }

           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home_page home = new Home_page();
            home.Show();
            this.Hide();
        }
    }
}
