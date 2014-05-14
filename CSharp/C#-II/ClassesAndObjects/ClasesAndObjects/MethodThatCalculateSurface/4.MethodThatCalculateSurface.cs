using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodThatCalculateSurface
{
    class MethodThatCalculateSurfaces
    {
        static double TriagleArea(double side, double altitude)
        {
            return (side * altitude) / 2;
        }
        static double TriagleArea(double side, double sideS, double sidel)
        {
            double poluPerimetar = (side + sidel + sideS) / 2;
            return Math.Sqrt(poluPerimetar * (poluPerimetar - sideS) * (poluPerimetar - sidel)
                * (poluPerimetar - side));
        }
        static double TriagleArea(double firstSide, double secodnSide, float angle)
        {
            double area;
            area = firstSide * secodnSide * Math.Sin(angle) / 2;
            return area;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(TriagleArea(4,4,1));
        }
    }
}
