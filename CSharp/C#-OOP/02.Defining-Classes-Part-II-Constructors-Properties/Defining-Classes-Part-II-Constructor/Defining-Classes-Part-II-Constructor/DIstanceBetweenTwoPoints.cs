using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_II_Constructor
{
    static class DIstanceBetweenTwoPoints
    {
        static public double Distance(Point3D first, Point3D second)
        {
            double xd = second.X - first.X;
            double yd = second.Y - first.Y;
            double zd = second.Z - first.Z;
            return Math.Sqrt(xd * xd + yd * yd + zd * zd);
        }
    }
}
