using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list3 = new LinkedList<string>();
            list3.Addlist("2");
            list3.Addlist("four");
            list3.Addlist("foo");

            foreach (string item in list3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
