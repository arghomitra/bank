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

namespace Bank_project
{
    public partial class CreateAccount : Form
    {
        Data database = new Data();
        User user = new User();
        Account account = new Account();

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(10000000, 99999999);
            textBox1.Text = randomNumber.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.Email = login.email;
            user = user.GetID(user);

            string email = login.email;
            string password = textBox3.Text;
            if (user.Verify(email, password) == 200)
            {
                account.AccountNo = textBox1.Text;
                account.Balance = Convert.ToDecimal(textBox2.Text);

                account.insertaccount(account, user);
                MessageBox.Show("Account created.");
                Home_page home = new Home_page();
                home.Show();
                this.Hide();
            }
            else
            {
                label6.Text = "wrong password";
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
