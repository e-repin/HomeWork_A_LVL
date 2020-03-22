using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Math
    {
        public static double Volume (double Length, double Width, double Height)
        {            
            return Length * Width * Height;
        }

        public static double BasePerimeter (double Length, double Width)
        {
            return 2 *(Length + Width);
        }       

        public static double BaseArea(double Length, double Width)
        {
            return Length * Width;
        }
        //Square cuboid
        public static double SquareGlobalArea(double LateralSurfaceArea, double BaseArea)
        {
            return LateralSurfaceArea + (2 * BaseArea);
        }
        public static double SquareLateralSurfaceArea(double Height, double BasePerimeter)
        {
            return Height * BasePerimeter;
        }
        //Rectangular cuboid
        public static double RectangularLateralSurfaceArea(double Length, double Width, double Height)
        {
            return (Height * 2) + (Length + Width);
        }

        public static double RectangularGlobalArea(double Length, double Width, double Height)
        {
            return 2 * ((Length + Width) + (Width + Height) + (Length + Height));
        }
        //Cub
        public static double CubArea (double Length)
        {
            return 6 * (Length * Length);
        }
    }
}
