using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Windows;

namespace EventSample
{
    public class Consumer
    {
        private string _name;

        //public string Name { get => _name; set => _name = value; }
        public Consumer(string name)
        {
            _name = name;
        }
        public void NewCarIsHere(object sender,CarInfoEventArgs e)
        {
            WriteLine($"{_name}: car {e.Car} is new");
        }
    }
}
