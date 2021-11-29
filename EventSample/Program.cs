using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EventSample
{
    //public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e)
    //    where TEventArgs : EventArgs;
    public class Program
    {
        static void Main(string[] args)
        {
            var dealer = new CarDealer();
            var daniel = new Consumer("Daniel");
            dealer.NewCarInfo += daniel.NewCarIsHere;

            dealer.NewCar("Mercedes");

            var sebastian = new Consumer("Sebastian");
            dealer.NewCarInfo += sebastian.NewCarIsHere;

            dealer.NewCar("Ferrari");

            dealer.NewCarInfo -= sebastian.NewCarIsHere;

            dealer.NewCar("Red Bull Racing");
             
        }
    }

    //public class CarInfoEventArgs : EventArgs
    //{
    //    public CarInfoEventArgs(string car)
    //    {
    //        Car = car;
    //    }
    //    public string Car { get; }
    //}
    //public class CarDealer
    //{
    //    private event EventHandler<CarInfoEventArgs> newCarInfo;
    //    public event EventHandler<CarInfoEventArgs> NewCarInfo
    //    {
    //        add
    //        {
    //            newCarInfo += value;
    //        }
    //        remove
    //        {
    //            newCarInfo -= value;
    //        }
    //    }
    //    public void NewCar(string car)
    //    {

    //        WriteLine($"CarDealer,new car {car}");
    //        NewCarInfo?.Invoke(this, new CarInfoEventArgs(car));
    //    }
    //}
}
