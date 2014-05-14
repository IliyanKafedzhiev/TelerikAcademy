using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Test
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[] { new Circle(3), new Rectangle(3, 34), new Triangle(3, 5) };
            foreach (Shape figure in shapes)
            {
                Console.WriteLine("I'm a "+figure.GetType().Name+"   ,and my Area is :" + figure.CalculateSurface());
            }
        }
    }
}
