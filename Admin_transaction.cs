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

    public partial class Admin_transaction : Form
    {
        Data database = new Data();

        User user = new User();
        Account account = new Account();
        public Admin_transaction()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_transaction_Load(object sender, EventArgs e)
        {
            string query = $"SELECT sender_account,receiver_account,date,amount FROM `transactions` ;";
            dataGridView1.DataSource = database.datatable(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Homepage home = new Admin_Homepage();
            home.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Homepage homepage = new Admin_Homepage();
            homepage.Show();
            this.Hide();
        }
    }
}
