using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Account ac1 = new CurrentAccount("CD2005", "Afifa");
            ac1.Deposit(25000);
            ac1.Withdraw(200);
            ac1.ShowInfo();
            Account ac2 = new CurrentAccount("CD2009", "Tazremin");
            ac2.Deposit(5000);
            ac2.Withdraw(500);
            ac2.ShowInfo();
            CurrentAccount.AddAccount(new OverdraftAccount("OD2005", "Afifa"));
            CurrentAccount.AddAccount(new SavingsAccount("SD2005", "Oishi"));
            CurrentAccount.ShowAccountInfo();

            SavingsAccount sa1 = new SavingsAccount("SD2005", "Oishi");
            sa1.Deposit(5000);
            sa1.Withdraw(50);
            sa1.ShowInfo();
            CurrentAccount ca1 = new CurrentAccount("CD2005", "Asraf");
            ca1.Deposit(500);
            ca1.Withdraw(500);
            ca1.ShowInfo();
            OverdraftAccount oc1 = new OverdraftAccount("OD2005", "Asif");
            oc1.Deposit(1000);
            oc1.Withdraw(3000);
            oc1.ShowInfo();

            Console.ReadKey();

        }
    }
}
