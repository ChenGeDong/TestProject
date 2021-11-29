using System;
using static System.Console;

namespace UsingInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankAccount venusAccount = new VenusBank();
            IBankAccount jupiterAccount = new JupiterBank();

            venusAccount.PayIn(200);
            venusAccount.Withdraw(100);
            WriteLine(venusAccount.ToString());

            jupiterAccount.PayIn(500);
            jupiterAccount.Withdraw(600);
            jupiterAccount.Withdraw(100);
            WriteLine(jupiterAccount.ToString());
        }
    }
}
