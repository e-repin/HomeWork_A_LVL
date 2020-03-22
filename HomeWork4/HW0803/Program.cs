using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0803
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string again;
            do
            {
                Console.Write("Enter size matrix NxN: ");
                int n = CustomMethods.ValidationStrInt(Console.ReadLine());
                n = CustomMethods.ValidationNull(n);

                Console.WriteLine("\nDefault matrix: \n");
                int[,] matrix = new int[n, n];
                Random random = new Random();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = random.Next(1, 99);
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\n=================================================\n");

                int[,] transpose = new int[n, n];               
                Console.WriteLine("Transpose matrix: \n");
               
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        transpose[i, j] = matrix[j, i];
                        Console.Write(transpose[i, j] + " \t ");

                        if (j == n - 1)
                            Console.WriteLine();
                    }
                }

                Console.WriteLine("\n=================================================\n");

                Console.WriteLine("Upper triangular matrix: \n");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j > i)
                        {
                            matrix[i, j] = 0;
                            Console.Write(matrix[i, j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n=================================================\n");

                Console.WriteLine("Lower triangular matrix: \n");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (i > j)
                        {
                            matrix[i, j] = 0;
                            Console.Write(matrix[i, j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\nAgain? Press Y or any key to exit");
                again = Console.ReadLine();
                Console.Clear();
            }
            while (again == "Y" || again == "y");
            
        }
    }
}

