using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Bank_project
{
    internal class Data
    {
       
        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bank;";
        MySqlConnection connection;
        MySqlCommand command;

        public void OpenConnection()
        
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        public void CloseConnection()
        {

            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlDataReader SelectQuery(string query)
        {
            OpenConnection();
            command = new MySqlCommand(query, connection);
            return command.ExecuteReader();
        }

        public int Insert(string query)
        
        {
            OpenConnection();
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            
            int result = commandDatabase.ExecuteNonQuery();
            return (int)commandDatabase.LastInsertedId;
        }
        public int Update(string query)
        
        {
            OpenConnection();
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            
            int result = commandDatabase.ExecuteNonQuery();
            return result;
        }
        public DataTable datatable(string query)
        {
            DataTable dt = new DataTable();
            OpenConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader mySqlDataReader= command.ExecuteReader();
            dt.Load(mySqlDataReader);

            return dt;
            
        }        
    }
}
