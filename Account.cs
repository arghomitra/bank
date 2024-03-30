using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bank_project
{
    internal class Account:User
    {
        User user = new User();
        
        Data database = new Data();
        
        public string AccountNo { get; set; }
        public User ID { get; set; }
        public Decimal Balance { get; set; }


        public Account()
        {

        }
        public Account(string accountNo,User userid,Decimal balance)
        {
            AccountNo = accountNo;
            ID= userid;
            Balance = balance;
        }





        public int insertaccount(Account account, User user)
        {
            string query = $"INSERT INTO `accounts` (`accountnumber`, `userid`, `balance`, `status`) " +
                           $"VALUES ('{AccountNo}', '{user.ID}', '{Balance}','Activate'); ";

            return database.Insert(query);
        }


        public int insertTransaction(int userID,string senderAccount, string receiverAccount,string date,Decimal amount)
        {
            string query = $"INSERT INTO `transactions` (`id`, `userID`, `sender_account`, `receiver_account`, `date`, `amount`) " +
                $"VALUES ('NULL', '{userID}', '{senderAccount}', '{receiverAccount}', '{date}', '{amount}');";

            return database.Insert(query);
        }

        public decimal GetBalance(User user)
        {
            // Retrieve the current balance from the database
            string query = $"SELECT balance FROM `accounts` WHERE userID = '{user.ID}'";
            MySqlDataReader output = database.SelectQuery(query);
            Decimal currentBalance = 0;
            
            if (output.Read())
            {
                currentBalance = Convert.ToDecimal(output[0]);
            }

            return currentBalance;        
        }

        public decimal GetBalanceByAccount(string accountNo)
        {
            // Retrieve the current balance from the database
            string query = $"SELECT balance FROM accounts where accountNumber ='{accountNo}';";
            MySqlDataReader output = database.SelectQuery(query);
            Decimal currentBalance = 0;

            if (output.Read())
            {
                currentBalance = Convert.ToDecimal(output[0]);
            }

            return currentBalance;
        }

        public string findAccount(User user)
        {
            string query = $"SELECT * FROM `accounts` WHERE userID = {user.ID};";
            MySqlDataReader output = database.SelectQuery(query);

            string accountNumber = string.Empty;

            if (output.Read())
            {
                accountNumber = Convert.ToString(output[0]);
            }

            return accountNumber;
        }

        public int UpdateBalance(Decimal balance, string accountNo)
        {
            string query = $"UPDATE accounts SET balance = {balance} WHERE accountNumber={accountNo};";
            return database.Update(query);
        }

        public int deactivateAccount(string accountNo)
        {
            string query = $"UPDATE `accounts` SET `status` = 'Deactivate' WHERE `accountNumber` = '{accountNo}';";
            return database.Update(query);
        }
        public int activateAccount(string accountNo)
        {
            string query = $"UPDATE `accounts` SET `status` = 'Activate' WHERE `accountNumber` = '{accountNo}';";
            return database.Update(query);
        }
        public string getStatus(string accountNo)
        {
            string query = $"SELECT status FROM accounts where accountNumber='{accountNo}';";
            MySqlDataReader output = database.SelectQuery(query);
            string currentStatus = string.Empty;

            if (output.Read())
            {
                currentStatus = Convert.ToString(output[0]);
            }

            return currentStatus;
        }
        public string accountsCounter()
        {
            string query = $"SELECT COUNT(accountNumber) FROM `accounts`;";
            MySqlDataReader output = database.SelectQuery(query);
            string accountCounter = string.Empty;

            if (output.Read())
            {
                accountCounter = Convert.ToString(output[0]);
            }

            return accountCounter;
        }
        public string accountsCounterByUserID(int userID)
        {
            string query = $"SELECT COUNT(accountNumber) FROM `accounts` where userID = {userID};";
            MySqlDataReader output = database.SelectQuery(query);
            string accountCounter = string.Empty;

            if (output.Read())
            {
                accountCounter = Convert.ToString(output[0]);
            }

            return accountCounter;
        }
        public string transactionsCounterByUserID(int userID)
        {
            string query = $"SELECT COUNT(id) FROM `transactions` WHERE userID={userID};";
            MySqlDataReader output = database.SelectQuery(query);
            string accountCounter = string.Empty;

            if (output.Read())
            {
                accountCounter = Convert.ToString(output[0]);
            }

            return accountCounter;
        }
        public string usersCounters()
        {
            string query = $"SELECT COUNT(id) FROM `users`;";
            MySqlDataReader output = database.SelectQuery(query);
            string userCounter = string.Empty;

            if (output.Read())
            {
                userCounter = Convert.ToString(output[0]);
            }

            return userCounter;
        }
        public string transactionCounter()
        {
            string query = $"SELECT COUNT(id) FROM `transactions`;";
            MySqlDataReader output = database.SelectQuery(query);
            string userCounter = string.Empty;

            if (output.Read())
            {
                userCounter = Convert.ToString(output[0]);
            }

            return userCounter;
        }
    }
}
