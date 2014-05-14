using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public override decimal CalculateSurface()
        {
            return (this.Height * this.Width) ;
        }
        public Rectangle(decimal width,decimal height):base(width,height)
        {
        }
    }
}
