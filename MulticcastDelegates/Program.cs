using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MulticcastDelegates
{
    /// <summary>
    /// 多播委托的了解学习
    /// 委托也可以包含多个方法。这种委托称为多播委托。
    /// 如果调用多播委托，就可以按顺序连续调用多个方法。
    /// 为此，委托的签名就必须返回void；
    /// 否则，就只能得到委托调用的最后一个方法的结果
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //多播委托识别+、+=、- 、-=这几个运算符，以再委托中删除增加方法
            Action<double> operations = MathOperations.MultiplyByTwo;
            operations += MathOperations.Square;
            ProcessAndDisplayNumber(operations,2.0);
            ProcessAndDisplayNumber(operations, 7.94);
            ProcessAndDisplayNumber(operations,1.141);
            



        }

        static void ProcessAndDisplayNumber(Action<double> action,double value)
        {
            WriteLine();
            WriteLine($"ProcessAndDisplayNumber called with value ={value}");
            action(value);
        }
    }
}
