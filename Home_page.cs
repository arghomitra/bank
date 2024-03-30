using MySqlConnector;
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
    public partial class Home_page : Form
    {
        Data database = new Data();
        User user = new User();
        Account account = new Account();

        public Home_page()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void button5_Click_1(object sender, EventArgs e)
        {
            login form1 = new login();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            transfer.Show();
            this.Hide();
        }

        private void Home_page_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            //string query = $"SELECT balance FROM `accounts` WHERE accountNo ='ab';";
            //MySqlDataReader output = database.SelectQuery(query);
            //if (output.Read())
            //{
            //    double balance = output.GetDouble(4); // Assuming the balance is stored as a double in the database
            //    label5.Text = balance.ToString(); // Convert the balance to a string and assign it to the label
            //}
            //else
            //{
            //    label5.Text = "No balance found"; // In case no balance is found in the database
            //}

            //output.Close();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void Home_page_Load_1(object sender, EventArgs e)
        {
            user.Email = login.email;
            user = user.GetID(user);
            label5.Text = account.GetBalance(user).ToString();
            label6.Text = account.findAccount(user).ToString();

            label2.Text = "Hi, "+user.First_name.ToUpper();

            string query = $"SELECT accountNumber ,balance,status FROM `accounts` WHERE userID={user.ID};";
            dataGridView1.DataSource = database.datatable(query);

            string query2 = $"SELECT sender_account,receiver_account,date,amount FROM `transactions` WHERE userID={user.ID};";
            dataGridView2.DataSource = database.datatable(query2);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Deposit depositdeposit = new Deposit();
            depositdeposit.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            login newPage = new login();
            newPage.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            editProfile profileEdit = new editProfile();
            profileEdit.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = dataGridView1.SelectedCells[0].Value.ToString();
            label6.Text = dataGridView1.SelectedCells[0].Value.ToString();
            try
            {
                label5.Text = account.GetBalanceByAccount(a).ToString();
            }
            catch
            {
                label5.Text = string.Empty;

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            transfer.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeleteAccount deleteAccount = new DeleteAccount();
            deleteAccount.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
