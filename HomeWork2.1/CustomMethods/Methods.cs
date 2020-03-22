using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMethods
{
    public class Methods
    {
        public static void Math (double x, double y, double z, out int TrainDay, out int CalendarDay, out double X)
        {
            TrainDay = 1;
            CalendarDay = 1;

            while (x < z)
            {
                TrainDay = TrainDay + 1;
                CalendarDay = CalendarDay + 2;
                double y1 = System.Math.Round((double)(x * y / 100));
                x = x + (x + y1);                
            }

            X = x;
        }
    }
}
