using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class CallByGSM
    {
        //fields
        private DateTime dateAndTime;
        private string dialedPhoneNumber;
        private int duration;

        //proparties
        public DateTime DateAndTime
        {
            get
            {
                return this.dateAndTime;
            }
            set
            {
                this.dateAndTime = value;
            }
        }
        public string DialedPhoneNumber
        {
            get
            {
                return dialedPhoneNumber;
            }
            set
            {
                this.dialedPhoneNumber = value;
            }
        }
        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                this.duration = value;
            }
        }

        //methods
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append("*************************************************************************************");
            info.Append("Date and Time :" + dateAndTime.ToString() + "\n");
            info.Append("Dialed Phone Number :" + dialedPhoneNumber + "\n");
            info.Append("Duration :" + duration + "\n");
            return info.ToString();
        }

        //constructor
        public CallByGSM(DateTime dateAndTime , string dialedPhoneNumber = null, int duration = 0)
        {
            DateAndTime = dateAndTime;
            DialedPhoneNumber = dialedPhoneNumber;
            Duration = duration;
        }
        public CallByGSM(CallByGSM other)
        {
            DateAndTime = other.DateAndTime;
            DialedPhoneNumber = other.DialedPhoneNumber;
            Duration = other.Duration;
        }

        //operators

        public static bool operator ==(CallByGSM c1, CallByGSM c2)
        {
            if (c1.DateAndTime != c2.DateAndTime)
            {
                return false;
            }
            if (c1.DialedPhoneNumber != c2.DialedPhoneNumber)
            {
                return false;
            }
            if (c1.Duration != c2.Duration)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(CallByGSM c1, CallByGSM c2)
        {
            if (c1.DateAndTime != c2.DateAndTime)
            {
                return true;
            }
            if (c1.DialedPhoneNumber != c2.DialedPhoneNumber)
            {
                return true;
            }
            if (c1.Duration != c2.Duration)
            {
                return true;
            }
            return false;
        }

        
    }
}
