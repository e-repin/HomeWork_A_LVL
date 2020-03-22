using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW0303
{
    
    public class Program
    {
        

        static void Main(string[] args)
        {            
            string again = "";
            int count=0;
            
            //string print;

            CustomMethods.SovershennoLetie();
            do
            {
                

                Console.WriteLine("\nWell, now you can play the game «Nalivaika», but first you need to fill in the position");

                Console.Write("\nЕnter degree of alcoholic drink: ");
                double degree = CustomMethods.FindDegree(CustomMethods.ValidationStrDoub(Console.ReadLine()));
                

                Console.Write("Enter the name of your drink: ");

                string name = Console.ReadLine();

                Console.Write("Enter the container in which the drink will be stored: ");

                string tara = Console.ReadLine();

                Console.Write("Enter capacity size: ");

                double size = CustomMethods.ValidationStrDoub(Console.ReadLine());

                Console.Write("Enter manufacturer: ");

                string manufacturer = Console.ReadLine();

                Console.Write("Enter country of manufacturer: ");

                string country = Console.ReadLine();
                
                count += 1;

                if (degree >= 1.5 && degree <= 8)
                {
                    Console.Write("Enter view of drink: ");
                    string view = Console.ReadLine();

                    Console.Write("Enter type of drink: ");
                    string type = Console.ReadLine();

                    var low_alcvohol = new LowAlcohol(name, degree, tara, size, manufacturer, country, view, type, count);
                    CustomMethods.Add(low_alcvohol);
                }
                else if (degree >= 9 && degree <= 30)
                {
                    Console.Write("Enter color of drink: ");
                    string color = Console.ReadLine();
                    var medium_alcvohol = new MediumAlcohol(name, degree, tara, size, manufacturer, country, color, count);
                    CustomMethods.Add(medium_alcvohol);
                }
                else
                {
                    Console.Write("Enter beverage exposure: ");
                    double excerpt = CustomMethods.ValidationStrDoub(Console.ReadLine());
                    var strong_alcvohol = new StrongAlcohol(name, degree, tara, size, manufacturer, country, excerpt, count);
                    CustomMethods.Add(strong_alcvohol);
                } 
                

               
                Console.WriteLine("\nAgain? Press Y to make another run or press any key to display the result: ");
                again = Console.ReadLine();
                               
            }
            while (again == "Y" || again == "y");
            
            

            CustomMethods.PrintMenu(CustomMethods.list);

            Console.WriteLine("Want to remove a drink? Press Y if yes or press any key to exit");
            again = Console.ReadLine();
            while (again == "Y" || again == "y")
            {
                Console.WriteLine("\nEnter the number of the item you want to delete: ");
                int delete = CustomMethods.ValidationStrInt(Console.ReadLine());
                delete -= 1;
                CustomMethods.Delete(delete);
                CustomMethods.PrintMenu(CustomMethods.list);
                Console.WriteLine("Want to remove another drink? Press Y if yes or press any key to exit");
                again = Console.ReadLine();                           
            } 
            



            Console.ReadKey();
                     

        }

    }   

}
