using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 100;
        public string userName {get;}

        public BankAccount()
        {
            userName = "guest";
        }

        public BankAccount(string name)
        {
            userName = name;
        }

        public void deposit(double amount) 
        {
            _balance += amount;
        }

        public double getBalance()
        {
            return _balance;
        }

        public void withdraw(double amount)
        {
            _balance -= amount;
        }
    }
}
