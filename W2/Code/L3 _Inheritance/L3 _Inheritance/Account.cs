using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3__Inheritance
{
    class Account:Person    //Inheritence
    {
        public Account() { }    //Constructor

        public Double getAccountBalance()
        {
            return currentAccount;
        }

        public double setAccountBalance(double amount)
        {
            currentAccount += amount;
            return currentAccount;
        }

        public double widthdrawFromAccount(double amountToWidthdraw)
        {
            currentAccount -= amountToWidthdraw;
            return currentAccount;
        }
    }
}
