using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListObjects;
using static System.Console;

namespace LinkedListObjectss
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new LinkedList();
            list1.AddLast(2);
            list1.AddLast(4);
            list1.AddLast("6");
            foreach (int item in list1)
            {
                WriteLine(item);
            }
        }
    }
}
