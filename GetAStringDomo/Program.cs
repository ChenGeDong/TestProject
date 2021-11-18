using System;
using static System.Console;

namespace GetAStringDomo
{
    class Program
    {
        delegate string GetAString();

        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int x = 40;
            //GetAString firstStringMethod = new GetAString(x.ToString);
            //GetAString secondStringMethod = x.ToString;
            //WriteLine($"String is {firstStringMethod.Invoke()}");

            //A a = new A(100.0f);
            //B b = (B)a;
            //WriteLine($"P of class a is {a.p}");
            //WriteLine($"P of class b is {b.p}");


            int x = 40;
            GetAString firstStringMethod = x.ToString;
            WriteLine($"STring is {firstStringMethod()}");

            var balance = new Currency(34,50);

            //firstStringMethod reference an instance method
            firstStringMethod = balance.ToString;
            WriteLine($"String is {firstStringMethod()}");

            //firstStringMethod reference a static method
            firstStringMethod = new GetAString(Currency.GetCurrencyUnit);
            WriteLine($"String is {firstStringMethod()}");

        }



        class A
        {
            public A(float f)
            {
                p = f;
            }
            public float p { get; }

            public static explicit operator B(A a)
            {
                return new B(a.p * 2);
            }
        }

        class B
        {
            public B(float f)
            {
                p = f;
            }
            public float p { get; }

            public static explicit operator A(B b)
            {
                return new A(b.p * 10f);
            }
        }
    }
}
