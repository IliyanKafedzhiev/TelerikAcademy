using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Human
{
    public class Worker : Human
    {
        public decimal WeekSalary
        {
            get;
            set;
        }

        public int WorksHoursPerDay
        {
            get;
            set;
        }

        public decimal MoneyPerHour()
        {
            return (WeekSalary / 5 ) / WorksHoursPerDay;
        }

        Worker(string FN,string LN ,decimal WS,int WHPD):base(FN,LN)
        {
            WeekSalary = WS;
            WorksHoursPerDay = WHPD;
        }
    }
}
