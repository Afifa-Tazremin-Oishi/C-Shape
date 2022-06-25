using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    abstract class Account : BasicBankingInterface
    {
        private static int autoIncmnt = 0;
        private string id;
        private string name;
        private double balance;
        private static int counter = 0;
        private static Account[] accountList = new Account[200];
        internal static void AddAccount(Account accountObject)
        {
            accountList[counter] = accountObject;
            counter++;
        }
        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        internal string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        internal Account(string id, string name)
        {
            autoIncmnt++;
            this.Id = id + autoIncmnt.ToString();
            this.Name = name;

        }

        internal virtual void ShowInfo()
        {
            Console.WriteLine(this.id);
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Total Balance: {0}", this.Balance);
           
        }
        internal static void ShowAccountInfo()
        {
            int loop = 0;
            Console.WriteLine("Show all Account :");
            while (loop < counter)
            {
                accountList[loop].ShowInfo();
                loop++;
            }
        }

        public abstract bool Deposit(double amount);
        public abstract bool Withdraw(double amount);

    }
}
