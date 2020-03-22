using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2902
{
    class MainMethods
    {
        //Validation a string check
        public static double ValidationStr(string str_x)
        {
            double x;
            while (!double.TryParse(str_x, out x))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Insert the number. Try again: ");
                Console.ResetColor();
                str_x = Console.ReadLine();

            }
            return x;
        }

        //Validation a null check
        public static double ValidationNull(double a)
        {

            while (a <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Num not equally null. Try again: ");
                Console.ResetColor();
                a = MainMethods.ValidationStr(Console.ReadLine());
                
            }
            return a;
        }
        
        public static double ValidationPercent(double a)
        {

            while (a > 100 || a == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("The number cannot be more than 100%. Try again: ");
                Console.ResetColor();
                a = MainMethods.ValidationStr(Console.ReadLine());
                MainMethods.ValidationNull(a);
            }
            return a;
        }
        
        public static double ValidationZ(double x, double z)
        {

            while (x > z || x == z)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Need to specify a greater mileage than the first day. Try again: ");
                Console.ResetColor();                
                z = MainMethods.ValidationStr(Console.ReadLine());
                MainMethods.ValidationNull(z);

            }
            return z;
        }
        
        public static void PrintMenu (int capacity, List<string> skiers)
        {
            for (int i = 0; i < capacity; i++)
            {
                Console.WriteLine(skiers[i]);
            }
        }


    }
}
