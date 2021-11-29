using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var dm = new DocumentManager<Document>();
            //dm.AddDocument(new Document("Title A", "Sample A"));
            //dm.AddDocument(new Document("Title B", "Sample B"));
            //dm.DisplayAllDocuments();

            //if (dm.IsDocumentAvailable)
            //{
            //    Document d = dm.GetDocument();
            //    Console.WriteLine(d.Content);
            //}


            //泛型类的静态成员只能在类的一个实例中共享
            StaticDemo<string>.x = 4;
            StaticDemo<int>.x = 5;
            Console.WriteLine(StaticDemo<string>.x);//输出为4

        }
    }


    /// <summary>
    /// 泛型类中的静态成员
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StaticDemo<T>
    {
        public static int x;
    }
    #region 泛型接口
    /// <summary>
    /// 泛型接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IComparable<in T>
    {
        int CompareTo(T other);
    }

    #endregion
}
