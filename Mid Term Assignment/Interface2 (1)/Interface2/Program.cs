using System;

namespace no2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac1 = new CurrentAccount("CA-1","Ashrafi");
            ac1.Deposit(25000);
            ac1.Withdraw(200);
            ac1.ShowInfo();
            Account ac2 = new CurrentAccount("CA-2","Sirajum");
            ac2.Deposit(5000);
            ac2.Withdraw(500);
            ac2.ShowInfo();
            CurrentAccount.AddAccount(new OverdraftAccount("CA-1","Ashrafi"));
            CurrentAccount.AddAccount(new SavingsAccount("SA-1","Mahjabin"));
            CurrentAccount.ShowAccountInfo();
           
            SavingsAccount sa1 = new SavingsAccount("SA-1","Mahjabin");
            sa1.Deposit(5000);
            sa1.Withdraw(50);
            sa1.ShowInfo();
            CurrentAccount ca1 = new CurrentAccount("CA-1","Asraf");
            ca1.Deposit(500);
            ca1.Withdraw(500);
            ca1.ShowInfo();
            OverdraftAccount oc1 = new OverdraftAccount("OA-2","Asif");
            oc1.Deposit(1000);
            oc1.Withdraw(3000);
            oc1.ShowInfo();
            Console.ReadKey();
            

        }
    }
}
