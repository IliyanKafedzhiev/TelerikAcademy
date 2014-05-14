using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class ExplodingBlock : Block
    {
        public new const string CollisionGroupString = "block";

        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {

        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "ball" || otherCollisionGroupString =="Un";
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            TrailObject[] obj = new TrailObject[]{};
            if (IsDestroyed)
            {
                obj = new TrailObject[] { new TrailObject(new MatrixCoords(this.topLeft.Row+1,this.topLeft.Col+1), new char[,] { { ' ' } }, 200) ,
                new TrailObject(new MatrixCoords(this.topLeft.Row-1,this.topLeft.Col-1), new char[,] { { ' ' } }, 200),
                new TrailObject(new MatrixCoords(this.topLeft.Row+1,this.topLeft.Col), new char[,] { { ' ' } }, 200),
                new TrailObject(new MatrixCoords(this.topLeft.Row,this.topLeft.Col+1), new char[,] { { ' ' } }, 200),
                new TrailObject(new MatrixCoords(this.topLeft.Row-1,this.topLeft.Col), new char[,] { { ' ' } }, 200),
                new TrailObject(new MatrixCoords(this.topLeft.Row,this.topLeft.Col-1), new char[,] { { ' ' } }, 200),
                new TrailObject(new MatrixCoords(this.topLeft.Row+1,this.topLeft.Col-1), new char[,] { { ' ' } }, 200),
                new TrailObject(new MatrixCoords(this.topLeft.Row-1,this.topLeft.Col+1), new char[,] { { ' ' } }, 200),};
            }
             
            return obj;
        }
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
    }
}
