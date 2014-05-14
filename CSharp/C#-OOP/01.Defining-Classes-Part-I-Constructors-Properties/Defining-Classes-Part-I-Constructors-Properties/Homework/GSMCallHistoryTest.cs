using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class GSMCallHistoryTest
    {
        static void Main(string[] args)
        {
            try
            {
                Battery bat = new Battery("Varta", 3, 6, BatteryType.NiMH);

                Display disp = new Display("800x600", 1000000);
                
                GSM gsm = new GSM("N90", "Nokia", 900, "Iliyan", bat, disp);

                CallByGSM Call1 = new CallByGSM(new DateTime(2013, 09, 23, 12, 43, 11), "0884 777 799", 240);
                CallByGSM Call2 = new CallByGSM(new DateTime(2013, 09, 28, 15, 42, 33), "0884 434 434", 160);
                CallByGSM Call3 = new CallByGSM(new DateTime(2013,11,9,5,23,1),"0884 777 119",90);
                CallByGSM Call4 = new CallByGSM(new DateTime(2012,04,2,3,43,11),"0884 777 111",111);
                gsm.AddCall(Call1);
                gsm.AddCall(Call2);
                gsm.AddCall(Call3);
                gsm.AddCall(Call4);
               
                gsm.PrintCallHistory();

                Console.WriteLine("Total Ammount : " + gsm.TotalPriceOfTheCalls((decimal)0.37));

                gsm.DeleteCall(Call1);

                Console.WriteLine("Total Ammount : " + gsm.TotalPriceOfTheCalls((decimal)0.37));

                gsm.ClearCallHistory();
                gsm.PrintCallHistory();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
