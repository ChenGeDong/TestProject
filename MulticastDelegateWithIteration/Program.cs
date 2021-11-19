using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace MulticastDelegateWithIteration
{
    /// <summary>
    /// 多播委托使用中注意的一个点：多个委托序列中，
    /// 如果有一个方法内部抛出异常，整个迭代就会停止
    /// </summary>
    class Program
    {
        static void One()
        {
            WriteLine("One");
            throw new Exception("Error in one");
        }
        static void Two()
        {
            WriteLine("Two");
        }
        static void Main(string[] args)
        {
            
            Action d1 = One;
            d1 += Two;
            //try
            //{
            //    d1();
            //}
            //catch (Exception)
            //{

            //    WriteLine("Exception caught");
            //}
            //为了避免以上情况的发生
            //应该自己迭代方法列表
            Delegate[] delegates = d1.GetInvocationList();
            foreach (Action d in delegates)
            {
                try
                {
                    d();
                }
                catch (Exception)
                {

                    WriteLine("Exception caught");
                }
            }
        }
    }
}
