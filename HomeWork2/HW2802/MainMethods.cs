using System;
using CustomMethods;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2802
{
    class MainMethods
    {
        public static int ValidationStr(string str_x)
        {
            int x;
            while (!int.TryParse(str_x, out x))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Insert the number. Try again: ");
                Console.ResetColor();
                str_x = Console.ReadLine();
                
            }
            return x;
        }

        public static int ValidationMaxMin(int a, int b)
        {
            while (a > b || a == b)
            {
                while (a > b)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Finish num must be greater than start num. Try again: ");
                    Console.ResetColor();
                    b = MainMethods.ValidationStr(Console.ReadLine());

                }
                while (a == b)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Finish num not equally start num. Try again: ");
                    Console.ResetColor();
                    b = MainMethods.ValidationStr(Console.ReadLine());
                }
            }
            return b;
        }
       


        public static int ValidationNull (int a)
        {          
            
            while (a <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Start num not equally null. Try again: ");
                Console.ResetColor();
                a = MainMethods.ValidationStr(Console.ReadLine());
            }
            return a;
        }
        public static int CheckSimpleNumbers (int a)
        {

            while  (CustomMethods.Methods.SimpleNumber(a) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Number is not simple. Try again: ");
                Console.ResetColor();
                a = MainMethods.ValidationStr(Console.ReadLine());                
                CustomMethods.Methods.SimpleNumber(a);                
            }
            return a;

        }

    } 
}
