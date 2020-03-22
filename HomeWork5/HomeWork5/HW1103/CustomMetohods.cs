using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1103
{
    public class CustomMetohods
    {
        public static double ValidationNull(double a)
        {

            while (a <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Num not equally null. Try again: ");
                Console.ResetColor();
                a = CustomMetohods.ValidationStr(Console.ReadLine());

            }
            return a;
        }
        public static int ValidationIntNull(int a)
        {

            while (a <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Num not equally null. Try again: ");
                Console.ResetColor();
                a = CustomMetohods.ValidationStrInt(Console.ReadLine());

            }
            return a;
        }


        public static double ValidationStr(string str)
        {
            double a;
            while (!double.TryParse(str, out a))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Insert the number. Try again: ");
                Console.ResetColor();
                str = Console.ReadLine();

            }
            return a;
        }

        public static int ValidationStrInt(string str)
        {
            int a;
            while (!int.TryParse(str, out a))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Insert the number. Try again: ");
                Console.ResetColor();
                str = Console.ReadLine();

            }
            return a;
        }

        public static void Print(Cuboid[] cubs, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(cubs[i].Print());
            }
        }

        public static void PrintOne(Cuboid[] cubs, int Count)
        {            
            Console.WriteLine(cubs[Count].Print());

        }

        
    }
}
