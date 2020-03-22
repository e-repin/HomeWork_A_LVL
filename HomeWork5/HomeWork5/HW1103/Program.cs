using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1103
{
    public struct Cuboid
    {
        double Length;
        double Width;
        double Height;
        double BaseArea;
        double Volume;
        double GlobalArea;
        double SurfaceArea;
        string Info;
        int Capacity;

        public Cuboid(double length, double width, double height, double baseArea, double volume, double globalArea, double surfaceArea, string info, int capacity)
        {
            Length = length;
            Width = width;
            Height = height;
            BaseArea = baseArea;
            Volume = volume;
            GlobalArea = globalArea;
            SurfaceArea = surfaceArea;
            Info = info;
            Capacity = capacity;

        }

        public string Print()
        {
            return $"\n{Capacity}){Info}\n{Length}x{Height}x{Width}\nArea: {BaseArea}\nVolume: {Volume}\nGlobalArea: {GlobalArea}\nSurfaceArea: {SurfaceArea}";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            double GlobalArea = 0;
            double SurfaceArea = 0;
            string Check;
            string Info;
            int Count = 0;
            int Capacity = 1;
            Cuboid[] cubs = new Cuboid[10];

            do
            {
                Console.Write("Enter length cube: ");
                double Length = CustomMetohods.ValidationNull(CustomMetohods.ValidationStr(Console.ReadLine()));

                Console.Write("Enter width cube: ");
                double Width = CustomMetohods.ValidationNull(CustomMetohods.ValidationStr(Console.ReadLine()));

                Console.Write("Enter heigh cube: ");
                double Height = CustomMetohods.ValidationNull(CustomMetohods.ValidationStr(Console.ReadLine()));

                double Volume = Geometry.Math.Volume(Length, Width, Height);
                double BaseArea = Geometry.Math.BaseArea(Length, Width);

                if (Width == Length)
                {
                    GlobalArea = Geometry.Math.RectangularGlobalArea(Length, Width, Height);
                    SurfaceArea = Geometry.Math.RectangularLateralSurfaceArea(Length, Width, Height);
                    Info = "This is square cuboid";

                    if (Height == Width && Height == Length)
                    {
                        BaseArea = Geometry.Math.CubArea(Length);
                        Info = "This is cube";
                    }
                }
                else
                {
                    SurfaceArea = Geometry.Math.SquareLateralSurfaceArea(Height, Geometry.Math.BasePerimeter(Length, Width));
                    GlobalArea = Geometry.Math.SquareGlobalArea(Geometry.Math.SquareLateralSurfaceArea(Height, Geometry.Math.BasePerimeter(Length, Width)), Geometry.Math.BaseArea(Length, Width));
                    Info = "This is rectangular cuboid";
                }

                cubs[Count] = new Cuboid(Length, Width, Height, BaseArea, Volume, GlobalArea, SurfaceArea, Info, Capacity);
                
                
                Console.WriteLine(cubs[Count].Print());
                Count += 1;
                Capacity += 1;

                Console.WriteLine("\nAdd more? Press Y or press any key to proceed to completion");
                Check = Console.ReadLine();
                if (Check.Equals("Y") || Check.Equals("y"))
                {
                    if (Capacity > 10)
                    {
                        Check = "n";
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have filled all the memory. Run the program again.\n");
                        Console.ResetColor();
                    }
                }

            }
            while (Check.Equals("Y") || Check.Equals("y"));            
            Console.WriteLine("Display a specific result or all? Press R to display one result, press A to display all the results\n(Press any key to exit)");
            Check = Console.ReadLine();

            if (Check.Equals("A") || Check.Equals("a"))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("All results are completed:");
                Console.ResetColor();
                CustomMetohods.Print(cubs, Count);
            }

            if (Check.Equals("R") || Check.Equals("r"))
            {
                Console.Clear();
                Console.Write("Enter result number: ");
                int Number = CustomMetohods.ValidationIntNull(CustomMetohods.ValidationStrInt(Console.ReadLine()));
                Number -= 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("One results are completed:");
                Console.ResetColor();
                CustomMetohods.PrintOne(cubs, Number);
            }
            Console.ReadKey();
        }
    }
}
