using System;
using System.Collections.Generic;
using System.Text;

namespace no2
{
    interface BasicBanking
    {
        bool Deposit(double amount);
        bool Withdraw(double amount);
    }  
}
