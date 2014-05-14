using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Matrix
{
    class Test
    {
        static void Main(string[] args)
        {
            Matrix<double> m1 = new Matrix<double>(2, 2, new double[2,2] {{2,3},{1,2}});
            
            Matrix<double> m2 = new Matrix<double>(2, 2,new double[2,2]{{1,2},{3,1}});

            Matrix<double> m3 = m1 - m2;
            Console.WriteLine( );
        }
    }
}
