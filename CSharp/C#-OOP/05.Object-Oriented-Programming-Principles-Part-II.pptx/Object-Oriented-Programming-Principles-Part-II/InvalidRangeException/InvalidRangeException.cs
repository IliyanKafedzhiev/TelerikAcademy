using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidRangeException
{
    class InvalidRangeException<T>:ApplicationException
    {
        private T start;
        private T end;
        public InvalidRangeException(T start, T end, string message):base(message)
        {
            this.start = start;
            this.end = end;
        }

        public override string Message
        {
            get
            {
                return base.Message + "\nDefined Range is form " + this.start.ToString() + " to :"+this.end.ToString();
            }
        }
    }
}
