using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball
    {
       
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft,speed)
        {
        }
        protected override void UpdatePosition()
        {
            this.TopLeft += this.Speed;
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            TrailObject[] obj = new TrailObject[]{new TrailObject(this.topLeft, new char[,] { { '.' } }, 3)};
            return obj;
        }
        public override void Update()
        {
            this.UpdatePosition();
        }
    }
}
