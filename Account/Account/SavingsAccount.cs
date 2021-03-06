﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    class SavingsAccount : Account
    {
        public SavingsAccount() { }
        public SavingsAccount(string accName, string accNo, double balance) : base(accName, accNo, balance)
        {
        }
        public override void Withdraw(double amount)
        {
            if (Balance - amount >= 500)
            {
                Balance -= amount;
                Console.WriteLine("Your acc is debited by {0} to self", amount);
            }
            else
            {
                Console.WriteLine("insufficient balance");
            }
        }
        public override void Transfer(Account a, double amount)
        {
            if (Balance - amount >= 500)
            {
                Balance -= amount;
                a.Balance += amount;
                Console.WriteLine("You account is debited by {0} to acc: {1} ({2})", amount, a.AccName, a.AccNo);
            }
            else
            {
                Console.WriteLine("insufficient balance");
            }
        }

    }
}