using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LambdaExpressions
{
    /// <summary>
    /// lambda表达式学习
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 如果lambda表达式只有一条语句，
             * 在方法块内就不需要花括号和return语句，
             * 因为编译器会添加一条隐式的return语句：
             * **/
            Func<string, string> oneParam = s => $"change uppercase {s.ToUpper()}";
            WriteLine(oneParam("test"));
            Func<double, double, double> twoParam = (x, y) => x * y;
            WriteLine(twoParam(3,2));
            Func<double, double, double> twoParamWithTypes = (double x, double y) => x * y;
            WriteLine(twoParamWithTypes(4,2));

            //自己添加return语句
            Func<double, double> square = x =>
             {
                 return x * x;
             };

            string mid = "";


            //lambda表达式实现代码中有多条药监局的情况，就biubiu添加花括号和return语句 fx:
            Func<string, string> lambda = param =>
             {
                 param += mid;
                 param += " and this wwas added to the string.";
                 return param;
             };


            /**
             * 闭包的概念：通过lambda表达式可以访问lambda表达式块外部的变量，这称为闭包
             * 闭包是非常好用的功能，但如果使用不当，也会非常危险
             * ***/
            int someVal = 5;
            Func<int, int> f = x => x + someVal;
            someVal = 7;
            WriteLine(f(3));

        }
    }
}
