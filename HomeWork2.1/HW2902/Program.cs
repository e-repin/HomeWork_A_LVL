using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2902
{
    class Program
    {
        static void Main(string[] args)
        {

            double x;
            double y;
            double z;
            double defaultx;
            int count = 1;
            int capacity = 0;
            int CalendarDay;
            int TrainDay;
            List<string> skiers = new List<string>();
            string info;
            string again;
            do
            {
                //Interrogate and verify
                Console.Write("Having started training, the skier ran on the first day km: ");
                x = MainMethods.ValidationStr(Console.ReadLine());
                MainMethods.ValidationNull(x);
                defaultx = x;
                Console.Write("Every next day he increased mileage by %: ");
                y = MainMethods.ValidationStr(Console.ReadLine());
                MainMethods.ValidationPercent(y);

                Console.Write("Total mileage for all days will exceed km: ");
                z = MainMethods.ValidationStr(Console.ReadLine());
                MainMethods.ValidationZ(x, z);

                //Count the distance
                CustomMethods.Methods.Math(x, y, z, out TrainDay, out CalendarDay, out x);

                //Create menu
                info = $"\n{count}) First day {defaultx} km.\nDistance by {y}%\nAchieved results on:\n- {TrainDay} training days\n- {CalendarDay} calendar days\nSum distance {x} km with {z} required.";
                //skiers.Insert(capacity, info);
                skiers.Add(info);
                Console.WriteLine(skiers[capacity]);
                capacity = capacity + 1;
                count = count + 1;

                //Loop again
                Console.WriteLine("\nAgain? Press Y to make another run or press any key to display the result: ");
                again = Console.ReadLine();
            }
            while (again == "Y" || again == "y");

            //Print
            MainMethods.PrintMenu(capacity, skiers);



        }
    }
}
