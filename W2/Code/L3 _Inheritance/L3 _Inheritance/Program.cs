using System;

namespace L3__Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();  //Instatiate account
            double currentAmount = 0.0;

            currentAmount = myAccount.setAccountBalance(1000.00);   //Save money in account
            Console.WriteLine("currentAmount : {0}", currentAmount);

            currentAmount = myAccount.widthdrawFromAccount(200.00);   //Widthdraw 200.00
            Console.WriteLine("currentAmount : {0}", currentAmount);

            currentAmount = myAccount.getAccountBalance();   //Get balance
            Console.WriteLine("currentAmount : {0}", currentAmount);
            Console.ReadLine();
        }
    }
}
