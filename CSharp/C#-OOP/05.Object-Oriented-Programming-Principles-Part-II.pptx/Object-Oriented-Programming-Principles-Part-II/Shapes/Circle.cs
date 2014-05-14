using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        public override decimal CalculateSurface()
        {
            return this.Height * (decimal)Math.PI * 2;
        }
        public Circle(decimal radius):base(radius,radius)
        {

        }
    }
}
