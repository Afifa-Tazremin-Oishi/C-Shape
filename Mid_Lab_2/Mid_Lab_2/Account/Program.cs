//A C# Program to simulate Account Operations among account objects.
using System;

namespace Account
{
    class Account
    {
        private string accName;
        private string acid;
        private int balance;
        public Account()
        {

        }
        public Account(string n, string i, int b)
        {
            accName = n;
            acid = i;
            balance = b;
        }

        public string AccName
        {
            get
            {
                return this.accName;
            }
            set
            {
                this.accName = value;
            }
        }


        public string Acid
        {
            get
            {
                return this.acid;
            }
            set
            {
                this.acid = value;
            }
        }

        public int Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public void deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine(amount + " Successfully Deposited.");
            Console.WriteLine("New Balance is now: " + Balance);
            Console.WriteLine();
        }

        public void withdraw(int amount)
        {
            if (amount >= balance)
            {
                Console.WriteLine("Amount Exceeds your Balance, Can not be withdrawn\n");
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine(amount + " Successfully Withdrawn.");
                Console.WriteLine("New Balance is now: " + Balance);
                Console.WriteLine();
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Account Information:\nAccount Name: " + AccName + ".");
            Console.WriteLine("Account No: " + Acid);
            Console.WriteLine("Current Balance : " + Balance);
            Console.WriteLine();
        }

        public void transfer(int amount, Account receiver)
        {
            if (balance <= amount)
            {
                Console.WriteLine("Amount Exceeds your Balance, Can not be Transfered\n");
            }
            else
            {
                balance = balance - amount;
                receiver.balance = receiver.balance + amount;
                Console.WriteLine(amount + " Successfully Transferred to " + receiver.accName);
                Console.WriteLine("Your Current Balance is : " + Balance);
                Console.WriteLine();
            }
        }
    }
    class program
    {

        public static void Main(string[] args)
        {
            Account A1 = new Account();
            Account A2 = new Account("Shopno", "567-89", 77000);
            A1.AccName = "Richman";
            A1.Acid = "21-78778-2";
            A1.Balance = 385000;
            A1.ShowInfo();
            A2.ShowInfo();

            A1.transfer(20000, A2);
            A1.deposit(5000);
            A1.withdraw(30000);

            A2.ShowInfo();
            A2.deposit(10000);
            A2.withdraw(5000);
            A2.transfer(20000, A1);
        }
    }
}