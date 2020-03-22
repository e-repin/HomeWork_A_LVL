using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0303
{
    abstract public class Alcohol
    {

        public Alcohol(string name, double degree, string tara, double size, string manufacturer, string country, int count)
        {
            Name = name;
            Degree = degree;
            Tara = tara;
            Size = size;
            Manufacturer = manufacturer;
            Country = country;
            Count = count;
        }

        public string Name { get; set; }
        
        public double Degree { get; set; }
        public string Tara { get; set; }
        public double Size { get; set; }
        public string Manufacturer { get; set; }
        public string Country { get; set; }
        public int Count { get; set; }

        public virtual string Print()
        {
            return $"{Count})  {Name} {Degree} {Tara} {Size} {Manufacturer} {Country}";

        }
    }
}
