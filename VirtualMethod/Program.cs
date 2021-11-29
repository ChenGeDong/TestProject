using System;
using static System.Console;

namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void DrawShape(Shape shape)
        {
            shape.Draw(shape);//这里可以是Shape的派生类实例    
        }
    }
    public class Shape
    {
        public void Draw(Shape shape)
        {

        }
        public virtual void Move(Position newPosition)
        {


            Position.X = newPosition.X;
            Position.Y = newPosition.Y;
            WriteLine($"moves to {Position}");

        }
    }

    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString() => $"X: {X}, Y: {Y}";


    }
}
