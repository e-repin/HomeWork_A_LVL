using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0303
{
    public class StrongAlcohol : Alcohol
    {
        
        public StrongAlcohol(string name, double degree, string tara, double size, string manufacturer, string country, double excerpt, int count) 
            : base(name, degree, tara, size, manufacturer, country, count)
        {
            Excerpt = excerpt;

        }
        double Excerpt { get; set; }

        public override string Print()
        {
           return $"{Count}) Category: Strong aclohol\nThe name drink: {Name}\nDegree of alcoholic drink: {Degree}°\nBeverage exposure: {Excerpt}\nСontainer: {Tara}.\nCapacity: {Size} liter\nManufacturer: {Manufacturer}\nThe country of manufacture: {Country}\n";

        }

    }
}
