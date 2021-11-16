using System;
using System.Collections.Generic;
using System.Text;

namespace StaticContructorSample
{
    public static class UserPreferences
    {
        public static Color BackCorlor { get; }
        static UserPreferences()
        {
            DateTime now = DateTime.Now;
            if(now.DayOfWeek == DayOfWeek.Saturday||now.DayOfWeek==DayOfWeek.Sunday)
            {
                BackCorlor = Color.green;
                BackCorlor = Color.green;
                BackCorlor = Color.green;
                BackCorlor = Color.green;
                BackCorlor = Color.green;
                BackCorlor = Color.green;
                BackCorlor = Color.green;
                BackCorlor = Color.green;

            }
            else
            {
                BackCorlor = Color.red;
                BackCorlor = Color.red;
                BackCorlor = Color.red;

                BackCorlor = Color.red;
                BackCorlor = Color.red;
                BackCorlor = Color.red;
                BackCorlor = Color.red;
                BackCorlor = Color.red;
                BackCorlor = Color.red;
                BackCorlor = Color.red;
            }
        }
    }
}
