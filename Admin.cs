using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_project
{
    internal class Admin
    {
        Data database = new Data();

        public int ID { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Admin()
        {

        }
        public Admin(int id, string first_name, string last_name, string email, string password)
        {
            ID = id;
            First_name = first_name;
            Last_name = last_name;
            Email = email;
            Password = password;
        }

        public int Verify(string email, string password)
        {
            string query = $"SELECT * FROM `admins` WHERE email = '{email}' and password = '{password}';";

            MySqlDataReader output = database.SelectQuery(query);


            while (output.Read())
            {
                if (output.HasRows)
                {
                    return 200;
                }
            }
            return 0;
        }

        public int insertaccountByAdmin(String accountNo, int userID,Decimal balance)
        {
            string query = $"INSERT INTO `accounts` (`accountnumber`, `userid`, `balance`, `status`) " +
                           $"VALUES ('{accountNo}', '{userID}', '{balance}','Activate'); ";

            return database.Insert(query);
        }
        public int UpdateByAdmin(int userID,string firstName,string lastName, string email, string password)
        {
            string query = $"UPDATE `users` SET `first_name` = '{firstName}', `last_name` = '{lastName}', `email` = '{email}', `password` = '{password}' WHERE `users`.`id` = {userID};";
            return database.Update(query);
        }
        public string adminName(string email)
        {
            string query = $"SELECT first_name FROM `admins` WHERE email='{email}';";
            MySqlDataReader output = database.SelectQuery(query);
            string name = string.Empty;

            if (output.Read())
            {
                name = Convert.ToString(output[0]);
            }

            return name;
        }

    }
}
