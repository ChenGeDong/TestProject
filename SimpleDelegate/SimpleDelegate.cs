using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDelegate
{
    public class SimpleDelegate
    {
        //声明委托类型
        public delegate void StringProcessor(string input);

        public StringProcessor Proc1, Proc2;

        public SimpleDelegate()
        {
            this.Proc1 = new StringProcessor(StaticMethod.PrintString);
        }
        void invoke(string input)
        {

        }
    }

    public class StaticMethod
    {
        public static void PrintString(string input)
        {

        }
    }
}
