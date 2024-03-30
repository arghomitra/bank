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
    public partial class Admin_accounts : Form
    {
        User user = new User();

        Data database = new Data();

        public Admin_accounts()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Homepage homepage = new Admin_Homepage();
            homepage.Show();
            this.Hide();
        }

        private void Admin_accounts_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM `accounts` ;";
            dataGridView1.DataSource = database.datatable(query);
        }

        private void button1_Click(object sender, EventArgs e)
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
