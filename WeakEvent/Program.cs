using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Console;

namespace WeakEvent
{
    public delegate void Mydelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Mydelegate mydelegate = new Mydelegate();
        }
    }
}
