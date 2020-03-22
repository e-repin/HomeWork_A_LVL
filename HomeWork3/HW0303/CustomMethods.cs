using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW0303
{
    public class CustomMethods
    {
        //Validation a string check
        public static double ValidationStrDoub(string str)
        {
            double num;
            while (!double.TryParse(str, out num))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Insert the number. Try again: ");
                Console.ResetColor();
                str = Console.ReadLine();

            }
            return num;
        }
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
        public static List<Alcohol> list = new List<Alcohol>();

        public static void Add(Alcohol alcohols)
        {
            list.Add(alcohols);
        }
        public static void Delete(int delete)
        {
            list.RemoveAt(delete);
        }
        
        public static void PrintMenu(List<Alcohol> list)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Alcohol menu complete!\n");
            Console.ResetColor();
            foreach (var alcohols in list)
            {
                Console.WriteLine(alcohols.Print());
            }

        }
        
        public static void SovershennoLetie()
        {
            Console.Write("Already have 18 years? Enter you age: ");
            int age = ValidationStrInt(Console.ReadLine());
            while (age < 18 || age > 60)
            {
                while (age < 18)
                {
                    Console.Write("Mamka bydet rygatsa. Again please: ");
                    age = ValidationStrInt(Console.ReadLine());
                }
                while (age > 60)
                {
                    Console.Write("Ti slishkom star dlya etogo derma :) Again please: ");
                    age = ValidationStrInt(Console.ReadLine());
                }
            }
        }
        public static double FindDegree(double degree)       
        {
            double x = degree;
            while (degree <= 1.4 || degree >= 81)
            {
                while (degree <= 1.4)
                {
                    Console.WriteLine("Limonad? Try again:");
                    degree = ValidationStrDoub(Console.ReadLine());
                }
                while (degree >= 81)
                {
                    Console.WriteLine("Ethanol? Try again:");
                    degree = ValidationStrDoub(Console.ReadLine());
                }
            }
            return x;
          

        }
    }
}
