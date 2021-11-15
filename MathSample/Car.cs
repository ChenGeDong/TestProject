using System;
using System.Collections.Generic;
using System.Text;

namespace MathSample
{
    class Car
    {

        private string _description;
        private uint _nwheels;
        //constructor
        public Car(string description,uint nwheels)
        {
            //implementation
            _description = description;
            _nwheels = nwheels;
        }
        //public Car(string description)
        //{
        //    //implementation
        //    _description = description;
        //    _nwheels = 4;

        //}

        //another implemention: Constructor initializer
        public Car(string description):this(description,4)//constructor	initializer
        {

        }
        //etc.

    }
}
