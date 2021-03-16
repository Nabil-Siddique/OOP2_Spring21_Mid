using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new SavingsAccount("Tanvir Ahmed", "789463", 50000);
            Account a2 = new CurrentAccount("Tanvir Ahmed", "789464", 50000);
            Account a3 = new SavingsAccount("Tanvir Ahmed Samsun Naher", "789465", 60000);

            Person p = new Person("Tanvir Ahmed");

            p.AddAccount(a1, a2, a3);
            p.ShowAccontDetails();

            var acc = p.GetAccount("789463");

            acc.Withdraw(49600);

        }
    }
}