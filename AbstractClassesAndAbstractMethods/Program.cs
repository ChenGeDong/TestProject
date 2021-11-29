using System;
using static System.Console;


/// <summary>
/// 类和方法可以声明为abstract
/// 抽象类不能被实例化，抽象方法不能直接实现，必须由派生类中重写
/// 抽象方法本身也是虚拟的
/// 如果类包含抽象方法，这个类也是抽象的，必须声明为抽象类
/// </summary>
namespace AbstractClassesAndAbstractMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
