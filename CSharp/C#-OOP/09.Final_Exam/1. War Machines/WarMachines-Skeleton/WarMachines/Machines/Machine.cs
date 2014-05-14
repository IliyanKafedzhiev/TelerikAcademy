using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMachines.Machines
{
    abstract class Machine : WarMachines.Interfaces.IMachine
    {
        private string name;
        private Interfaces.IPilot pilot;
        private double healtPoints;
        protected double attackPoints;
        protected double defensePoints;
        private IList<string> targets;

        protected Machine(string name,Interfaces.IPilot pilot,double healtPoints,
            double attackPoints,double defensePoints,IList<string> targets)
        {
            Name = name;
            this.pilot = pilot;
            HealthPoints = healtPoints;
            if (attackPoints != null && attackPoints >= 0)
            {
                this.attackPoints = attackPoints;
            }
            if (defensePoints != null && defensePoints >= 0)
            {
                this.defensePoints = defensePoints;
            }
            if (targets != null)
            {
                this.targets = new List<string>();
                foreach (string item in targets)
                {
                    this.targets.Add(item);
                }
            }
            else
            {
                this.targets = new List<string>();
            }

        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Machine name is not set correctly!");
                }
            }
        }

        public Interfaces.IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                if (value != null)
                {
                    this.pilot = value;
                }
                else
                {
                    throw new ArgumentException("The argument Pilot is Null");
                }
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healtPoints;
            }
            set
            {
                if (value != null && value >= 0)
                {
                    this.healtPoints = value;
                }
                else
                {
                    throw new ArgumentException("The Healt Points are not set correctly");
                }
            }
        }

        public double AttackPoints
        {
            get { return this.attackPoints; }
        }

        public double DefensePoints
        {
            get { return defensePoints; }
        }

        public IList<string> Targets
        {
            get { return this.targets; }
        }

        public void Attack(string target)
        {
            if (target != null)
            {
                this.targets.Add(target);
            }
        }

        public override string ToString()
        {
            StringBuilder Info = new StringBuilder();
            Info.Append(" *Health: " + this.healtPoints + "\n");
            Info.Append(" *Attack: " + this.attackPoints + "\n");
            Info.Append(" *Defense: " + this.defensePoints + "\n");
            Info.Append(" *Targets: ");
            if ( this .targets == null || this.targets.Count == 0)
            {
                Info.Append("None" + "\n");
            }
            else
            {
                for (int i = 0; i < this.targets.Count; i++)
                {
                    if (i == this.targets.Count - 1)
                    {
                        Info.Append(this.targets[i]);
                    }
                    else
                    {
                        Info.Append(this.targets[i] + ", ");
                    }
                }
                Info.Append("\n");
            }
            return Info.ToString();
        }
    }
}
