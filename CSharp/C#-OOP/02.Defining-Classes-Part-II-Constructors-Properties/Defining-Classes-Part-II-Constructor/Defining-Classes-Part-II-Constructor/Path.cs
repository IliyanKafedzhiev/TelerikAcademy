using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_II_Constructor
{
    class Path
    {
        private List<Point3D> sequence;
        
        public List<Point3D> Sequence
        {
            get
            {
                return sequence;
            }
            set
            {
                this.sequence = value;
            }
        }

        public Path(List<Point3D> seq = null)
        {
            Sequence = (seq == null)?new List<Point3D>():seq;
        } 

        public void  AddPoint(Point3D point)
        {
            Sequence.Add(point);
        }

        public override string ToString()
        {
            StringBuilder build = new StringBuilder();
            for (int i = 0; i < Sequence.Count; i++)
            {
                build.Append("Point:"+i+"\n"+ Sequence[i].ToString() + "\n");
            }
            return build.ToString();
        }
    }
}
