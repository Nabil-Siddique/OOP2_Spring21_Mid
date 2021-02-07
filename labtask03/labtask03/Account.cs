using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask03
{
    class Account
    {
        string accName;
        string acId;
        int balance;

        public string AccName { get => accName; set => accName = value; }
        public string AcId { get => acId; set => acId = value; }
        public int Balance { get => balance; set => balance = value; }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                Balance = Balance + amount;
                Console.WriteLine("Added amount =" + balance);
            }
        }
        public void Withdraw(int amount)
        {
            if (amount <= balance || amount > 0)
            {
                Balance = Balance - amount;
                Console.WriteLine("Left amount =" + balance);
            }
        }
    }
}
