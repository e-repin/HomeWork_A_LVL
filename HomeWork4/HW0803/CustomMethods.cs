using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0803
{
    class CustomMethods
    {
        public static int ValidationStrInt(string str)
        {
            int num;
            while (!int.TryParse(str, out num))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Insert the number. Try again: ");
                Console.ResetColor();
                str = Console.ReadLine();

            }
            return num;
        }
        public static int ValidationNull(int a)
        {

            while (a <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Num not equally null. Try again: ");
                Console.ResetColor();
                a = CustomMethods.ValidationStrInt(Console.ReadLine());

            }
            return a;
        }
    }
}
