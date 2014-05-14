using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class Triangle : Shape
    {
        public override decimal CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
        public Triangle(decimal width,decimal height):base(width,height)
        {
        }
    }
}
