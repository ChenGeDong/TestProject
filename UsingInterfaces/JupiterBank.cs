using System;
using System.Collections.Generic;
using System.Text;

namespace UsingInterfaces
{
    public class JupiterBank : IBankAccount
    {
        //etc
        public decimal Balance => throw new NotImplementedException();

        public void PayIn(decimal amount)
        {
            throw new NotImplementedException();
        }

        public bool Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
