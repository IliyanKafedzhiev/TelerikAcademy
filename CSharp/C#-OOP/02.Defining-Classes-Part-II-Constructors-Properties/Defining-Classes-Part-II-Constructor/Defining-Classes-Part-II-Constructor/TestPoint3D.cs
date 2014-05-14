using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_II_Constructor
{
    class TestPoint3D
    {
        static void Main(string[] args)
        {
            Point3D spot = new Point3D(9, 9, 9);
            Console.WriteLine(spot);
            Console.WriteLine(Point3D.ZeroPoint());
            double disBetweenZeroAndSpot = DIstanceBetweenTwoPoints.Distance(Point3D.ZeroPoint(), spot);
            Console.WriteLine(disBetweenZeroAndSpot);
            Path L = PathStorage.LoadPaths("text.txt");
            Console.WriteLine(L);
            PathStorage.SavePaths(L, "Paths.txt");
            
        }
        
    }
}
