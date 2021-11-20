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
            A a1 = new A { X = 1 };
            AA aa1 = new AA { X = 1 };
            //ChangeA(a1);
            //ChangeA(aa1);
            
            //WriteLine($"a1.x:{a1.X}");
            //WriteLine($"aa1.x:{aa1.X}");

            //ChangeAA(ref a1);
            //WriteLine($"a1.x:{a1.X}");

            ChangeAAA(ref aa1);
            WriteLine($"a1.x:{aa1.X}");
        }
        public static void ChangeA(A a)
        {
            a.X = 2;
        }


        /// <summary>
        /// 这里一定要理解，传递的是引用的引用，而非应用的副本所以方法运行后，传入的参数会变
        /// </summary>
        /// <param name="a"></param>
        public static void ChangeAAA(ref AA a)
        {
            a.X = 2;
            a = new AA { X = 3 };
        }

        /// <summary>
        /// ref 
        /// </summary>
        /// <param name="a"></param>
        public static void ChangeAA(ref A a)
        {
            a.X = 2;
        }
        public static void ChangeA(AA aa)
        {
            aa.X = 2;
        }
    }
    

    public struct A
    {
        public int X { get; set; }
    }
    public class AA
    {
        public int X { get; set; }
    }
}
