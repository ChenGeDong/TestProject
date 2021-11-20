using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OutKeyWordSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = ReadLine();
            int a = int.Parse(input1);
            WriteLine($"a:{a}");
            string input2 = ReadLine();
            int result;
            if(int.TryParse(input2,out result))
            {
                WriteLine($"a:{a}");
            }
            else
            {
                WriteLine("not a number");
            }
        }
        //public static bool TryParse(string s,out int result)

    }
}
