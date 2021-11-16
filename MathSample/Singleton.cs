using System;
using System.Collections.Generic;
using System.Text;

namespace MathSample
{
    public class Singleton
    {
        private static Singleton s_instance;
        private int _state;
        //Constructor
        private Singleton(int state)
        {
            _state = state;
        }

        public static Singleton Instance
        {
            get { return s_instance ?? (s_instance = new Singleton(42)); }
        }
    }
}
