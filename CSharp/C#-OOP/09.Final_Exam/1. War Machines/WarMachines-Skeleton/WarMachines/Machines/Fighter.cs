using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMachines.Machines
{
    class Fighter:Machine,WarMachines.Interfaces.IFighter
    {
        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, null, 200, attackPoints, defensePoints, null)
        {
            this.stealthMode = stealthMode;
        }
        public bool StealthMode
        {
            get { return this.stealthMode; }
        }

        public void ToggleStealthMode()
        {
            if (!this.stealthMode)
            {
                this.stealthMode = true;
            }
            else
            {
                this.stealthMode = false;
            }
        }

        public override string ToString()
        {
            StringBuilder Info = new StringBuilder();
            Info.Append("- " + this.Name + "\n");
            Info.Append(" *Type: " + "Fighter" + "\n");
            Info.Append(base.ToString());
            Info.Append(" *Stealth: ");
            if (this.StealthMode)
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
