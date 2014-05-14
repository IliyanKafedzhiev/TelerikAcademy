using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_II_Constructor
{
    struct Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        private static readonly double[] Point0 = new double[3] { 0, 0, 0 };

        public static Point3D ZeroPoint()
        {
            return new Point3D(Point0[0], Point0[1], Point0[2]);
        }
        public Point3D(double x , double y , double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public override string ToString()
        {
            return X+"\n"+Y+"\n"+Z;
        }
    }
}
