using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework
{
    class Battery
    {
        //fields
        private string model;
        private int hourIdle;
        private int hourTalk;
        private BatteryType batType;
        
        //proparties
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (model =="")
                {
                    throw new ArgumentException("Empty model");
                }
                this.model = value.Trim();
            }

        }
        public int HourIdle
        {
            get
            {
                return hourIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Erorr Negative hourIdle");
                }
                this.hourIdle = value;
            }
        }
        public int HourTalk
        {
            get
            {
                return hourTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Erorr Negative hourTalk");
                }
                this.hourTalk = value;
            }
        }
        public BatteryType BatType
        {
            get
            {
                return batType;
            }
            set
            {
                this.batType = value;
            }
        }

        //constructor
        public Battery(string modelP = null, int hourIdleP = 0, int hourTalkP = 0 ,BatteryType batType = 0)
        {
            Model = modelP;
            HourIdle = hourIdleP;
            HourTalk = hourTalkP;
            BatType = batType;
        }

        //operators
        public override string ToString()
        {
            string batery = "";
            switch ((int)BatType)
	            {
                    case 0:
                        batery = "None";
                        break;
                    case 1:
                        batery = "LiIon";
                        break;
                    case 2:
                        batery = "NiMH";
                        break;
                    case 3:
                        batery = "NiCd";
                        break;
		            default:
                        break;
	            };
            return "Model :" + ((Model == null) ? "" : Model) + "\n" +
                "HourIdle :" + ((HourIdle == 0) ? "" : HourIdle.ToString()) + "\n" +
                "HourTalk :" + ((HourTalk == 0) ? "" : HourTalk.ToString()) + "\n" +
                "BatteryType :" +  batery ;
                
        }
    }
}
