using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMachines.Pilotes
{
    class Pilot:Interfaces.IPilot
    {
        private string name;
        private IList<Interfaces.IMachine> machines;

        public Pilot(string name)
        {
            this.name = name;
            this.machines = new List<Interfaces.IMachine>();
        }
        public string Name
        {
            get { return name; }
        }

        public void AddMachine(Interfaces.IMachine machine)
        {
            if (machine != null)
            {
                machine.Pilot = (Interfaces.IPilot)this;
                this.machines.Add(machine);
            }
            else
            {
                throw new ArgumentException("Machine Added in Pilot List is Null");
            }
            var orderedMachines = this.machines.OrderBy(y => y.Name).OrderBy(x => x.HealthPoints);
            this.machines = new List<Interfaces.IMachine>();
            foreach (Interfaces.IMachine item in orderedMachines)
            {
                this.machines.Add(item);
            }
        }

        public string Report()
        {
            StringBuilder Info = new StringBuilder();
            Info.Append(this.Name + " - ");
            if (this.machines == null || this.machines.Count == 0)
            {
                Info.Append("no ");
                Info.Append("machines");
            }
            else
            {
                Info.Append(this.machines.Count);
                if (this.machines.Count == 1)
                {
                    Info.Append(" machine\n");
                }
                else
                {
                    Info.Append(" machines\n");
                }
            }
            //Info.Append("\n");
            if (this.machines.Count > 0)
            {
                for (int i = 0; i < this.machines.Count; i++)
                {
                    if (i == this.machines.Count - 1)
                    {
                        Info.Append(this.machines[i].ToString());
                    }
                    else
                    {
                        Info.Append(this.machines[i].ToString()+ "\n");
                    }
                }
            }
            return Info.ToString();
        }
    }
}
