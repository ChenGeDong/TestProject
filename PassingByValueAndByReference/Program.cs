using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PassingByValueAndByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A { X=1};
            ChangeA(ref a1);
            WriteLine($"a1.x:{a1.X}");
        }
        //public struct A
        //{
        //    public int X { get; set; }
        //}

        public class A
        {
            public int X { get; set; }
        }
        public static void ChangeA(ref A a)
        {
            a.X = 2;
            a = new A { X = 3 };
        }


    }
}
