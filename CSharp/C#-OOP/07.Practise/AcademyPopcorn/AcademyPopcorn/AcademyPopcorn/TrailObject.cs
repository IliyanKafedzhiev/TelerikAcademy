using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class TrailObject : GameObject
    {
        private int lifeTime;
        public TrailObject(MatrixCoords topLeft,char[,] body,int lifeTime):base(topLeft,body)
        {
            this.lifeTime = lifeTime;
        }
        public override string GetCollisionGroupString()
        {
            return TrailObject.CollisionGroupString;
        }
        public override void Update()
        {
            lifeTime--;
            if (lifeTime<0)
            {
                this.IsDestroyed = true;
            }
        }
        public new const string CollisionGroupString = "TrialObject";

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "ball" || otherCollisionGroupString =="block";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
    }
}
