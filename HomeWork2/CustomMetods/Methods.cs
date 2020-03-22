using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMethods
{
    public class Methods
    {
        public static int[] RangeOfNumbers(int a, int b)
        {
            int x = b - a + 1;
            int[] d = new int[x];
            for (int i = 0; i < x; i++)
            {
                d[i] = a + i;
            }
            return d;
        }
        public static bool SimpleNumber (int n)
        {
            var result = true;
            if (n > 1)
            {
                for (var i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
