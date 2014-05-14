using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public abstract class Shape
    {
        private decimal height;
        private decimal width;

        public decimal Height
        {
            get
            {
                return height;
            }
        }
        public decimal Width
        {
            get
            {
                return width;
            }
        }
        public abstract decimal CalculateSurface();
        public Shape(decimal height , decimal width)
        {
            if (height < 0 || width < 0)
            {
                throw new ArgumentException();
            }
            this.width = width;
            this.height = height;
        }
    }
}
