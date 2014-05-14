using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Display
    {
        // fields
        private string size;
        private int numberOfColors;

        //proparties
        public string Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("Empty Parameter");
                }
                this.size = value.Trim();
            }
        }
        public int NumberOfColors
        {
            get
            {
                return numberOfColors;
            }
            set
            {
                    if (value < 0)
                    {
                        throw new Exception("Empty Parameter");
                    }
                    this.numberOfColors = value;
            }
        }

        //constructor
        public Display(string sizeP = null, int numOfColorP = 0)
        {
            Size = sizeP;
            NumberOfColors = numOfColorP;
        }
        public Display(int numOfColorP = 0, string sizeP = null)
        {
            Size = sizeP;
            NumberOfColors = numOfColorP;
        }

        //operator
        public override string ToString() 
        {
            return "Size :" + ((Size == null)?"":Size) + "\n" + 
                "Number of Colors:" + ((NumberOfColors == 0)?"":NumberOfColors.ToString());
        }
    }
}
