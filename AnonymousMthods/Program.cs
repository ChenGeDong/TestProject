using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace AnonymousMthods
{
    /// <summary>
    /// 匿名方法Anonymous Method
    /// 
    /// 匿名方法是用作委托的参数的一段代码
    /// 
    /// 在匿名方法内部不能访问不安全的代码。
    /// 另外，也不能访问在匿名方法外部使用的ref和out参数。
    /// 但可以使用在匿名方法外部定义的其他变量。
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            string mid = ", middle part, ";
            Func<string, string> anonDel = delegate (string param)
             {
                 param += mid;
                 param += "and this was added to the string.";
                 return param;
             };
            WriteLine(anonDel("Start of string"));
        }
    }
}
