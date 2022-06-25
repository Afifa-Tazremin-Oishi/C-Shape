using System;
using System.Collections.Generic;
using System.Text;

namespace no2
{
    class CurrentAccount : Account
    {
        private static int YYYY = 0;
        public String id;
        public String XXXX
        {
            set { this.id = value; }
            get { return this.id; }
           
        }

        internal CurrentAccount(String id,string name) : base("CA-1",name)
        {
            
        }

        public override bool Deposit(double amount)
        {
            bool found = false;
            if (500 <= amount)
            {
                Balance = Balance + amount;
                found = true;
                Console.WriteLine("Congratulation! {0} have sucessefully added to your account!", amount);
            }
            else Console.WriteLine("Minimum 500 taka needs to deposit!");
            return found;
        }

        public override bool Withdraw(double amount)
        {
            bool found = false;
            if (Balance >= amount && Balance > 0)
            {
                if (amount <= 5000 && amount > 0)
                {
                    Balance = Balance - amount;
                    found = true;
                    Console.WriteLine("{0} Withdraw Sucessfully! ", amount);
                }
                else Console.WriteLine("Sorry! You can withdraw maximum 5000 at a time and minimum is greater than 0! ");
            }

            else
            {
                Console.WriteLine("Not enough Balance! ");
            }
            return found;
        }

        internal override void ShowInfo()
        {
            Console.WriteLine("Showing Current Account info...");
            Console.WriteLine("ID:", this.Id);
            base.ShowInfo();
        }
    }
}
