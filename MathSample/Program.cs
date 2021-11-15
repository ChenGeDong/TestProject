using System;
using static System.Console;

namespace MathSample
{
    class Program
    {
        //The type or namespace name "Retangle" could not be found
        // Are you messing a using directive or an assembly reference


        
        //Try calling some static functions
        static void Main(string[] args)
        {
            //Try calling static function GetPi
            WriteLine($"Pi is {Math.GetPi()}");
            int x = Math.GetSquareOf(5);
            WriteLine($"Square of 5 is{x}");
            //instantiate a math object
            var math = new Math();//instantiate a reference type

            //call instance members
            math.Value = 30;
            WriteLine($"Value field of math variable contains{math.Value}");
            WriteLine($"square of 30 is {math.GetSquare()}");

            //named Arguments
            math.MoveAndResize(30,11,12,13);
            math.MoveAndResize(x: 30, y:11,Height:12,Width:13);
            //Optional Arguments
            math.TestMethod(11,opt3:4);
            math.TestMethod(11,20);

            //Variable number of arguments
            math.AnyNumberOfArgument(1);
            math.AnyNumberOfArgument(1,2,3,4,5,6,7,8,9);
            math.AnyNumberOfArgument(1,3);
            math.AnyNumberOfArgument(1,101111111);
            int[] arrayInt = { 1, 2, 3, 4, 5 };
            math.AnyNumberOfArgument(arrayInt);
            //constructors
            //var number = new MyNumber();//given
            //Console.WriteLine("Hello World!");

            var myCar = new Car("Proton Persona");
        }

        public bool IsSquare(Rectangle rect)
        {
            return false;
        }
        public bool isSquare(Rectangle rect) => rect.Height == rect.Width;
    }
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
    public class Math
    {
        public int Value { get; set; }
        public int GetSquare() => Value * Value;
        public static int GetSquareOf(int x) => x * x;
        public static double GetPi() => 3.14159;

        //named Arguments
        public void MoveAndResize(int x, int y, int Height, int Width)
        {

        }

        //Optional Arguments
        //You must be supply a default value for optional parameter, which must be the last ones defined
        public void TestMethod(int notOptionalNumber,int optionalNumber = 42)
        {

        }

        public void TestMethod(int n,int opt1 = 11,int opt2 = 12,int opt3 = 13)
        {
            WriteLine(n+opt1+opt2+opt3);
        }
        //Variable number of arguments
        public void AnyNumberOfArgument(params int[] data)
        {
            foreach (var item in data)
            {
                WriteLine(item);
            }
        }

        public void AnyNumberOfArgument(params object[] data)
        {
            foreach (var item in data)
            {
                WriteLine(item.ToString());
            }
        }
    }

    class ResultDisplayer
    {

        public void DisplayResult(string result)
        {
            //implementation
        }
        public void DisplayResult(int result)
        {
            //implementation
        }
    }

    class MyClass
    {
        //constructor
        public MyClass()//zero parameter constructor
        {

        }
        public MyClass( int number)//another consotructor
        {
            //construction code
        }
        //rest of class difinition

        //One overloaded method can invoke another
        public int DoSomething(int x)
        {
            //Cannot implicitly convert type 'string' to 'int'
            return DoSomething(x,10);
        }
        public int DoSomething(int x,int y)
        {
            //implementation
            return 0;
        }

      
    }
    public class MyNumber
    {
        private int _number;
        private MyNumber(int number)
        {
            _number = number;
        }
    }
}
