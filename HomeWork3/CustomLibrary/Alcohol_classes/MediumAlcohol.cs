using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0303
{
    public class MediumAlcohol : Alcohol
    {
        
        public MediumAlcohol(string name, double degree, string tara, double size, string manufacturer, string country, string color, int count)
            : base(name, degree, tara, size, manufacturer, country, count)
        {
            Color = color;
        }
        string Color { get; set; }
        public override string Print()
        {
            return $"{Count}) Category: Medium aclohol\nThe name drink: {Name}\nDegree of alcoholic drink: {Degree}°\nColor drink: {Color}\nСontainer: {Tara}.\nCapacity: {Size} liter\nManufacturer: {Manufacturer}\nThe country of manufacture: {Country}\n";

        }
    }

    
}
