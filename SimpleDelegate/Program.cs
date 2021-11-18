using System;
using static System.Console;
using System.Collections;

namespace SimpleDelegate
{
    class Program
    {
        delegate double DoubleOp(double x);
        static void Main(string[] args)
        {
            DoubleOp[] operations =
            {
                MathOperations.MultiplyByTwo,
                MathOperations.Square
            };
               

            for (int i = 0; i < operations.Length; i++)
            {
                WriteLine($"Using operations[{i}]");
                ProcessAndDisplayNumber(operations[i],2.0);
                ProcessAndDisplayNumber(operations[i],7.9);
                ProcessAndDisplayNumber(operations[i],1.141);
                WriteLine();
            }

            Func<double, double>[] operationss =
            {
                MathOperations.MultiplyByTwo,
                MathOperations.Square
            };
            for (int i = 0; i < operationss.Length; i++)
            {
                WriteLine($"Using operations[{i}]");
                ProcessAndDisplayNumber(operations[i], 2.0);
                ProcessAndDisplayNumber(operations[i], 7.9);
                ProcessAndDisplayNumber(operations[i], 1.141);
                WriteLine();
            }




            //Console.WriteLine("Hello World!");
        }
        static void ProcessAndDisplayNumber(DoubleOp action, double value)
        {
            double result = action(value);
            WriteLine($"Value is {value},result of operation is {result}");
        }
        static void ProcessAndDisplayNumber(Func<double,double> action,double value)
        {
            double result = action(value);
            WriteLine($"value is { value},result of operation is {result}");
        }
    }
}
