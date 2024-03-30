using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bank_project
{
    internal class User
    {
        Data database = new Data();

        public int ID { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
            
        }
        public User(int id,string first_name,string last_name,string email, string password)
        {
            ID = id;
            First_name = first_name;
            Last_name = last_name;
            Email = email;
            Password = password;
        }

        public int Verify(string email, string password)
        {
            string query = $"SELECT * FROM `users` WHERE email = '{email}' and password = '{password}';";

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

        public int findUser(string email)
        {
            string query = $"SELECT * FROM `users` WHERE email = '{email}';";
            MySqlDataReader output = database.SelectQuery(query);

            while (output.Read())
            {
                if (output.HasRows)
                {
                    return 1;
                }
            }
            return 0;
        }


        public int InsertUser(User user)
        {
            string query = $"INSERT INTO `users` (`id`, `first_name`, `last_name`, `email`, `password`) " +
                $"VALUES(NULL, '{user.First_name}', '{user.Last_name}', '{user.Email}', '{user.Password}'); ";


            return database.Insert(query);
        }
        public User GetID(User user)
        {
            // Retrieve the current balance from the database
            string query = $"SELECT * FROM `users` WHERE email = '{user.Email}'";
            MySqlDataReader output = database.SelectQuery(query);
            int id = -1;

            if (output.Read())
            {
                user.ID = Convert.ToInt16(output[0]);
                user.First_name = output[1].ToString();
                user.Last_name = output[2].ToString();
                user.Email = output[3].ToString();
                user.Password = output[4].ToString();
            }

            return user;
        }

        public User GetUser(int userID)
        {
            string query = $"SELECT * FROM `users` WHERE id = '{userID}'";
            MySqlDataReader output = database.SelectQuery(query);

            if (output.Read())
            {
                User user = new User();
                user.ID = Convert.ToInt16(output[0]);
                user.First_name = output[1].ToString();
                user.Last_name = output[2].ToString();
                user.Email = output[3].ToString();
                user.Password = output[4].ToString();
                // Set other properties of the User object as needed

                output.Close();
                return user;
            }

            output.Close();
            return null; // User not found
        }

        public int Update(User user)
        {
            string query = $"UPDATE `users` SET `first_name` = '{user.First_name}', `last_name` = '{user.Last_name}', `email` = '{user.Email}', `password` = '{user.Password}' WHERE `users`.`id` = {user.ID};";
            return database.Update(query);
        }
    }
}
