using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace UsingInterfaces
{
    public class VenusBank : IBankAccount
    {
        private decimal _balance;
        public decimal Balance => throw new NotImplementedException();

        public void PayIn(decimal amount) => _balance += amount;

        public bool Withdraw(decimal amount)
        {
            if(_balance >= amount)
            {
                _balance -= amount;
                return true;
            }
            WriteLine("withdrawal attempt failed");
            return false;
        }


        public decimal Blance => _balance;
        public override string ToString() => $"Venus Bank Saver:Balance = {_balance,6:C}";
     
    }
}
