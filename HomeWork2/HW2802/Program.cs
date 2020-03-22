using System;
using CustomMethods;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2802
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;            
            int num_1;
            int num_2;
            int index = 0;
            string str;            
            string again;
            string check = "null";
            

            Console.WriteLine("This console application checks the multiplicity of numbers from the range you entered,\n" +
                "depending on what you entered the requested factors.");

            do
            {
                Console.Write("\nEnter start num: ");
                str = Console.ReadLine();
                num_1 = MainMethods.ValidationStr(str);
                num_1 = MainMethods.ValidationNull(num_1);


                Console.Write("Enter finish num: ");
                num_2 = MainMethods.ValidationStr(Console.ReadLine());
                MainMethods.ValidationMaxMin(num_1, num_2);

                int[] x = Methods.RangeOfNumbers(num_1, num_2);

                do
                {
                    Console.Write("\nEnter first prime factor: ");
                    str = Console.ReadLine();
                    a = MainMethods.ValidationStr(str);
                    a = MainMethods.ValidationNull(a);
                    Methods.SimpleNumber(a);
                    MainMethods.CheckSimpleNumbers(a);

                    Console.Write("Enter second prime factor: ");

                    str = Console.ReadLine();
                    b = MainMethods.ValidationStr(str);
                    b = MainMethods.ValidationNull(b);
                    Methods.SimpleNumber(b);
                    MainMethods.CheckSimpleNumbers(b);

                    if (a == b)
                    {
                        Console.Write("First simple num not second simple num. Try again\n");
                    }
                }
                while (a == b);
                
                for (int i = num_1; i < num_2; i++)
                {                    
                    if (x[index] % a == 0)
                    {
                        check = $"\nFizz {x[index]} / {a}";
                        Console.WriteLine(check);
                        if (x[index] % b == 0)
                        {
                            check = $"\nFizzBuzz {x[index]} / {a} and {b}";
                            Console.WriteLine(check);
                        }
                    }                    
                    if (x[index] % b == 0)
                    {
                        check = $"\nBuzz {x[index]} / {b}";
                        Console.WriteLine(check);
                    }                    
                    index = index + 1;                   

                }
                if (check == "null")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nNo multiple");
                    Console.ResetColor();
                }
                Console.Write("\nAgain? Press Y and other key: ");
                again = Console.ReadLine();
            }
            while (again == "Y" || again == "y");
        }
    }
}





