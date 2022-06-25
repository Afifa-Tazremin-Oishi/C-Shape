using System;
using System.Collections.Generic;
using System.Text;

namespace no2
{
    class OverdraftAccount : Account
    {
        private static int autoIncmnt = 0;
        public String id;
        public string XXXX
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal OverdraftAccount(string id,string name) : base("OA-1", name)
        {

        }

        public override bool Deposit(double amount)
        {
            bool found = false;
            if (0 < amount)
            {
                Balance = Balance + amount;
                found = true;
                Console.WriteLine("\nCongratulation! {0} have sucessefully added to your account", amount);
            }
            else Console.WriteLine("Amount should  be greater than 0!");
            return found;
        }

        public override bool Withdraw(double amount)
        {
            bool found = false;
                if (Balance-amount > Balance)
                {
                    Balance = Balance - amount;
                    found = true;
                    Console.WriteLine("Withdraw Sucessfully! ");
                }
                else Console.WriteLine("Sorry! Your account is overdraft!");
            
            return found;
        }

        internal override void ShowInfo()
        {
            Console.WriteLine("Showing Overdraft Account info...");
            Console.WriteLine("ID: {0}", this.Id);
            base.ShowInfo();
        }
    }
}
