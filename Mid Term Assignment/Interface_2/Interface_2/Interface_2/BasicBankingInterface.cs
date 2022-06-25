using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    interface BasicBankingInterface
    {
        bool Deposit(double amount);
        bool Withdraw(double amount);
    }
}
