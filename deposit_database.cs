using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_project
{
    internal class deposit_database
    {
        Deposit deposit = new Deposit();
        Data database = new Data();

        public int ID { get; set; }
        public string AccountNo { get; set; }
        public int Amount { get; set; }
        public string Communication { get; set; }

        public deposit_database(int id, string accountNo, int amount,string communication)
        {
            ID = id;
            AccountNo = accountNo;
            Amount = amount;
            Communication = communication;
            

        }

        //public int insertaccount(user user)
        //{
        //    string query = $"insert into `deposit` (`id`, `account_no`, `amount`, `communication`)" +
        //        $"values('{deposit_database.id}', '{deposit_database.a}', '45', 'slkjlka lkaj ajklj ajklfjda ');";
             

        //    return database.insert(query);
        //}

    }
}
