using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    class Person
    {
        public string Name { get; set; }
        Account[] accounts;
        public int AccCount { get; set; }
        public Person() { }
        public Person(string name)
        {
            Name = name;
            accounts = new Account[10];
        }
        public void AddAccount(params Account[] accounts)
        {
            foreach (Account acc in accounts)
            {
                this.accounts[AccCount++] = acc;
            }
        }
        public void ShowAccontDetails()
        {
            for (int i = 0; i < AccCount; i++)
            {
                accounts[i].ShowInfo();
            }
        }
        public Account GetAccount(string accNo)
        {
            Account a = null;
            for (int i = 0; i < AccCount; i++)
            {
                if (accNo.Equals(accounts[i].AccNo))
                {
                    a = accounts[i];
                    break;
                }
            }
            return a;
        }
    }
}