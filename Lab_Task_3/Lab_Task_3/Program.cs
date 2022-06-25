using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_3
{
    class Program
    {

        class Account
        {
          
            private string accName;
            private string acid;
            private int balance;

           
            public Account()
            {
                this.accName = null;
                this.acid = null;
                this.balance = 0;
            }
           
            public Account(string a, string aid, int b)
            {
                this.accName = a;
                this.acid = aid;
                this.balance = b;
            }

           
            public string AccName
            {
                set { this.accName = value; }
                get { return this.accName; }
            }
            public string Acid
            {
                set { this.acid = value; }
                get { return this.acid; }
            }
            public int Balance
            {
                set { this.balance = value; }
                get { return this.balance; }
            }

            
            public void Deposit(int amount)
            {
                if (amount > 0)
                {
                    balance = balance + amount;
                    Console.WriteLine("Balance {0} is added in account", amount);
                    Console.WriteLine("Deposited successfully\nNew balance after deposit: {0}", balance);
                    Console.WriteLine("\n");
                }
                else
                    Console.WriteLine("Invalid Input!! \n");
            }
            public void Withdraw(int amount)
            {
                if (amount < 0 && amount > balance)                 
                {
                    Console.WriteLine("Withdraw failed!! \n");
                }
                else
                {
                    balance = balance - amount;
                    Console.WriteLine("Balance {0} is deducted from account", amount);
                    Console.WriteLine("Withdrawn successfully\n New balance after withdraw: {0} ", balance);
                    Console.WriteLine("\n");
                }

            }

            public void Transfer(int amount, Account receiver)
            {
                if (amount < 0 && amount > balance)
                {
                    Console.WriteLine("Transferred failed due to insufficient balance!! \n");
                }
                else
                {
                    this.balance = balance - amount;                           
                    receiver.balance = receiver.balance + amount;                        
                    Console.WriteLine("Transfered successfully!! After transfer new balance is {0} \n", this.balance);
                    Console.WriteLine("Receiver Balance: {0} ", receiver.balance);
                    Console.WriteLine("\n");
                }

            }

            static void Main(string[] args)
            {


                Account a1 = new Account(); 
                a1.AccName = "Hasibul Islam"; 
                a1.Acid = "23-4";
                a1.Balance = 1000;
                Console.WriteLine("Account Name: " + a1.AccName + "     Account ID: " + a1.Acid + "     Balance: " + a1.Balance);
                a1.Deposit(500);
                a1.Withdraw(200);


                Account a2 = new Account();
                a2.AccName = "Emon";
                a2.Acid = "10-9";
                a2.Balance = 4000;
                Console.WriteLine("Account Name:" + a2.AccName + "  Account ID: " + a2.Acid + "  Balance: " + a2.Balance);
                a2.Transfer(400, a1);

                Account a3 = new Account("Emrul", "12-1", 100000);
                a3.Withdraw(3000);
                a3.Transfer(1000, a1);

                Account a4 = new Account("Hasan", "21-2", 41500);
                a4.Deposit(1200);
                a4.Transfer(1000, a3);


                
                Console.ReadLine();  
            }
        }
    }
}
