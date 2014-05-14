using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMachines.Machines
{
    class Tank : Machine, WarMachines.Interfaces.ITank
    {
        private bool defenseMode;

        public Tank(string name, double attackPoints, double defensePoints)
            :base(name,null,100,attackPoints,defensePoints,null)
        {
            this.ToggleDefenseMode();
        }
        public bool DefenseMode
        {
            get { return this.defenseMode; }
        }

        public void ToggleDefenseMode()
        {
            if (!this.defenseMode)
	        {
		        this.defensePoints +=30;
                this.attackPoints -= 40;
                this.defenseMode = true;
	        }
            else
	        {
                this.defensePoints -= 30;
                this.attackPoints += 40;
                this.defenseMode = false;
	        }
        }

        public override string ToString()
        {
            StringBuilder Info = new StringBuilder();
            Info.Append("- " + this.Name + "\n");
            Info.Append(" *Type: " + "Tank" + "\n");
            Info.Append(base.ToString());
            Info.Append(" *Defense: ");
            if (this.DefenseMode)
            {
                Info.Append("ON");
            }
            else
            {
                Info.Append("OFF");
            }
            return Info.ToString();
        }
    }
}
