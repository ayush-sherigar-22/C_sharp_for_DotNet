using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace EncapsulationPractice
{
    public class BankAccount
    {
        private float _balance;
        public float Balance { get { return _balance; } }

        public void Withdraw(float amnt)
        {
            if(amnt> _balance)
            {
                throw new InvalidOperationException("Insufficinet Balance in the aoount");

            }

           _balance -= amnt;
            Console.WriteLine("Money successfully withdrawed.");
            Console.WriteLine($"Current balance: {_balance}");
        }

       

        public void Deposit(float amount)
        {
            if(amount < 0)
            {
                throw new InvalidOperationException("Insufficient amounbt entered.");
            }
            _balance += amount;
            Console.WriteLine("Money successfully deposited");
            Console.WriteLine($"Current balance: {_balance}");
        }
    }
}
