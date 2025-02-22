using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace review3
{
    internal class BankingSystem
    {
        // 3).Banking System
        //Create a custom exception called InsufficientFundsException.
        // a banking application where:
        //A user can withdraw money.
        //Throw InsufficientFundsException if the balance is less than the withdrawal amount

        public double balance;
        public BankingSystem(double balance)
        {
            this.balance = balance;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InsufficientFundException(" Insufficient fund !");
            }

            Console.WriteLine(amount + " is withdraw");
        }

    }
}
