using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0303
{
    public class LowAlcohol : Alcohol
    {
       
        public LowAlcohol (string name, double degree, string tara, double size, string manufacturer, string country, string view, string type, int count) 
            : base (name, degree, tara, size, manufacturer, country, count)
        {
           View = view;
           Type = type;
        }



        string View { get; set; }
        string Type { get; set; }

        public override string Print()
        {
            return $"{Count}) Category: Low aclohol\nThe name drink: {Name}\nDegree of alcoholic drink: {Degree}°\nСontainer: {Tara}.\nCapacity: {Size} liter\nManufacturer: {Manufacturer}\nThe country of manufacture: {Country}\n";

        }
    }
}
