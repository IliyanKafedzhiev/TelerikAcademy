using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class IndestructibleBlock : Block
    {
        public new const string CollisionGroupString = "IndestructibleBlock";
        public char Symbol = '|';

        public IndestructibleBlock(MatrixCoords upperLeft,char Symbol = '|')
            : base(upperLeft)
        {
            this.Symbol = Symbol;
            this.body[0, 0] = this.Symbol;
        }
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "ball" ||otherCollisionGroupString=="UnstopableBall";
        }
        public override void RespondToCollision(CollisionData collisionData)
        {
            //base.RespondToCollision(collisionData);
        }
        public override string GetCollisionGroupString()
        {
            return IndestructibleBlock.CollisionGroupString;
        }
    }
}
