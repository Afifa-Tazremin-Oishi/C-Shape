using System;
using System.Collections.Generic;
using System.Text;

namespace no2
{
    class SavingsAccount : Account
    {
        private static int autoIncmnt = 0;
        public String id;
        public String XXXX
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal SavingsAccount(String id,string name) : base("SA-1", name)
        {

        }

        public override bool Deposit(double amount)
        {
            bool found = false;
            if (0 < amount)
            {
                Balance = Balance + amount;
                found = true;
                Console.WriteLine("\nCongratulation! {0} have sucessefully added to your account!", amount);
            }
            else
            {
                Console.WriteLine("Amount should  be greater than 0!");
            }
            return found;
        }

        public override bool Withdraw(double amount)
        {
            bool found = false;
            if (Balance >= amount && Balance > 0)
            {
                if (amount <= amount*0.8 && amount > 0) 
                { 
                    Balance = Balance - amount; found = true; 
                }
                else Console.WriteLine("Sorry! You cannot withdraw the desired amount!");
            }

            else Console.WriteLine("Not enough Balance! ");
            return found;
        }

        internal override void ShowInfo()
        {
            Console.WriteLine("Showing Savings Account info...");
            Console.WriteLine("ID: {0}", this.Id);
            base.ShowInfo();
        }
    }
}
