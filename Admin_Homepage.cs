using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
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
    public partial class Admin_Homepage : Form
    {
        Account account = new Account();
        User user = new User();

        Data database = new Data();
        Admin admin = new Admin();

        public Admin_Homepage()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_users users = new Admin_users();
            users.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_accounts accounts = new Admin_accounts();
            accounts.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_login login = new Admin_login();
            login.Show();
            this.Hide();
        }

        private void Admin_Homepage_Load(object sender, EventArgs e)
        {
            string email = Admin_login.email;
            label3.Text = admin.adminName(email).ToUpper();

            label5.Text = account.accountsCounter();
            label1.Text = account.usersCounters();
            label2.Text = account.transactionCounter();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_deleteAccount delete = new Admin_deleteAccount();
            delete.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_transaction tr = new Admin_transaction();
            tr.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_createAccount create = new Admin_createAccount();
            create.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label6.Text = "User ID";
            label1.Text = Convert.ToString(textBox1.Text);
            int id = Convert.ToInt32(textBox1.Text);
            label5.Text = account.accountsCounterByUserID(id);
            label2.Text = account.transactionsCounterByUserID(id);
            string query = $"SELECT u.first_name, u.last_name, u.email, u.password ,a.accountNumber, a.balance,a.status FROM users as u JOIN accounts as a ON u.id = a.userID WHERE u.id = {id};";
            dataGridView2.DataSource = database.datatable(query);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Admin_EditProfile edit = new Admin_EditProfile();
            edit.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Admin_createUser create = new Admin_createUser();
            create.Show();
            this.Hide();
        }
    }
}
