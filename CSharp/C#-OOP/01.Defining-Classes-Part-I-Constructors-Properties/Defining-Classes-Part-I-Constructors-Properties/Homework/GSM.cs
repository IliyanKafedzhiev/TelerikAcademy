using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework
{
    class GSM
    {
        //fields
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery batteryCharacteristic;
        private Display displayCharacteristic;

        private static string iPhone4S = "";

        private List<CallByGSM> callHistory;

        //proparties
        public string Model   
        {
            get
            {
                return this.model;

            }
            set
            {
                if (value == "")
                {
                    throw new Exception("Empty Parameter");
                }
                this.model = value.Trim();
            }
            
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;

            }
            set
            {
                if (value == "")
                {
                    throw new Exception("Empty Parameter");
                }
                this.manufacturer = value.Trim();
            }

        }
        public double Price
        {
            get
            {
                return this.price;

            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Empty Parameter");
                }
                this.price = value;
            }

        }
        public string Owner
        {
            get
            {
                return this.owner;

            }
            set
            {
                if (value == "")
                {
                    throw new Exception("Empty Parameter");
                }
                this.owner = value.Trim();
            }

        }
        public Battery BatteryCharacteristic
        {
            get
            {
                return this.batteryCharacteristic;
            }
            set
            {
                this.batteryCharacteristic = value;
            }
        }
        public Display DisplayCharacteristic
        {
            get
            {
                return this.displayCharacteristic;
            }
            set
            {
                this.displayCharacteristic = value;
            }
        }
        public static string IPhone4S
        {
            get
            {
                return iPhone4S;
            }
            set
            {
                iPhone4S = value;
            }
        }
        public List<CallByGSM> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                for (int i = 0; i < value.Count; i++)
                {
                    this.callHistory.Add(value[i]);
                }
            }

        }
        
        //methods
        public void PrintInfo()
        {
            Console.WriteLine("Model :" + Model);
            Console.WriteLine("Manufacturer :" + Manufacturer);
            if (Price != -1)
            {
                Console.WriteLine("Price :" + Price);
            }
            if (Owner != null)
            {
                Console.WriteLine("Owner :" + Owner);
            }
            if (BatteryCharacteristic != null)
            {
                Console.WriteLine(BatteryCharacteristic.ToString());
            }
            if (DisplayCharacteristic != null)
            {
                Console.WriteLine(DisplayCharacteristic.ToString());
            }

        }
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Model :" + Model );
            info.Append("\n");
            info.Append("Manufacturer :" + Manufacturer);
            info.Append("\n");
            if (Price != -1)
            {
                info.Append("Price :" + Price);
                info.Append("\n");
            }
            if (Owner != null)
            {
                info.Append("Owner :" + Owner);
                info.Append("\n");
            }
            if (BatteryCharacteristic != null)
            {
                info.Append("\n");
                info.Append("\n");
                info.Append("Battery Info:");
                info.Append("\n");
                info.Append("\n");
                info.Append(BatteryCharacteristic.ToString());
                info.Append("\n");
            }
            if (DisplayCharacteristic != null)
            {
                info.Append("\n");
                info.Append("\n");
                info.Append("Display Info:");
                info.Append("\n");
                info.Append("\n");
                info.Append(DisplayCharacteristic.ToString());
                info.Append("\n");
            }
            return info.ToString();
        }
        public void AddCall(CallByGSM call)
        {
            this.callHistory.Add(new CallByGSM(call));
        }
        public void DeleteCall(CallByGSM call)
        {
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                if (this.callHistory[i] == call)
                {
                    this.callHistory.RemoveAt(i);
                }
            }
        }
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }
        public decimal TotalPriceOfTheCalls(decimal pricePerMinute)
        {
            decimal sum = 0;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                sum +=(decimal) ((decimal)this.callHistory[i].Duration / 60);
            }
            return sum  * pricePerMinute;
        }
        public void PrintCallHistory()
        {
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                Console.WriteLine(this.callHistory[i].ToString());
            }
        }

        

        //constructors
        public GSM(string model, string manufacturer , double price = -1, string owner = null,
            Battery battery = null, Display display = null)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
            BatteryCharacteristic = battery;
            DisplayCharacteristic = display;
            this.callHistory = new List<CallByGSM>();
        }
        public GSM(string model, string manufacturer, Display display = null, double price = -1, string owner = null,
            Battery battery = null)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
            BatteryCharacteristic = battery;
            DisplayCharacteristic = display;
            this.callHistory = new List<CallByGSM>();
        }
        public GSM(string model, string manufacturer,Battery battery = null , Display display = null,
            double price = -1, string owner = null)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
            BatteryCharacteristic = battery;
            DisplayCharacteristic = display;
            this.callHistory = new List<CallByGSM>();
        }
        public GSM(string model, string manufacturer, string owner = null, Battery battery = null, Display display = null,
           double price = -1)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
            BatteryCharacteristic = battery;
            DisplayCharacteristic = display;
            this.callHistory = new List<CallByGSM>();
        }
    }
}
