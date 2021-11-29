using System;
using System.Collections.Generic;
using System.Text;

namespace UsingInterfaces
{
    public interface IBankAccount
    {
        void PayIn(decimal amount);

        bool Withdraw(decimal amount);

        decimal Balance { get; }

    }
}
