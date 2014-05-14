using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class UnpassableBlock : IndestructibleBlock
    {
        public new const string CollisionGroupString = "UnpassableBlock";
        public UnpassableBlock(MatrixCoords upperLeft,char Symbol = '|')
            : base(upperLeft,Symbol)
        {
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            //base.RespondToCollision(collisionData);
        }
        public override string GetCollisionGroupString()
        {
            return UnpassableBlock.CollisionGroupString;
        }
    }
}
