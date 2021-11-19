using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample
{
    public class CarDealer
    {
        public event EventHandler<CarInfoEventArgs> NewCarInfo;

        ////定义事件的长记法
        //private event EventHandler<CarInfoEventArgs> NewCarInfo
        //{
        //    add
        //    {
        //        newCarInfo += value;
        //    }
        //    remove
        //    {
        //        newCarInfo -= value;
        //    }
        //}
        /// <summary>
        /// 动态创建订阅器时，为了避免出现资源泄露，必须特别留意事件。
        /// 也就是说，需要在订阅器离开作用域（不再需要它）之前，确保取消对事件的订阅，或者使用弱事件。
        /// 事件常常是应用程序中内存泄露的一个原因，
        /// 因为订阅器有长时间存在的作用域，所以源代码也不能被垃圾回收

        /// </summary>
        /// <param name="car"></param>
        public void NewCar(string car )
        {
            Console.WriteLine($"CarDealer,new car {car}");
            NewCarInfo?.Invoke(this,new CarInfoEventArgs(car));
        }

    }
}
