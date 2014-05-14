using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class TestGSM
    {
        static void main(string[] args)
        {
            try
            {
                Battery[] bat = new Battery[] { new Battery("Varta", 3, 6, BatteryType.NiMH), new Battery("Dell", 8, 16, BatteryType.LiIon) };
                
                Display[] disp = new Display[]{new Display("800x600", 1000000),new Display("1600x800",5000000)};
                
                GSM[] arrayOfGSM = new GSM[] { new GSM("N90", "Nokia", 900, "Iliyan", bat[0], disp[0]), new GSM("X8", "SonyErricson", 400, "Pesho", bat[1], disp[1]),
                    new GSM("3310", "Nokia", 900, "Iliyan", bat[0], disp[1]),
                    new GSM("XMusic", "Nokia", 900, "Iliyan", bat[1], disp[0]) };

                GSM.IPhone4S = "Apple's new iPhone 4S is just last year's design loaded with a new brain and more memory. It will run your apps faster and Apple's new iOS5's Assistant, an artificial intelligence program that listens and interprets your orders, and a new camera.";
                
                for (int i = 0; i < arrayOfGSM.Length; i++)
                {
                    Console.WriteLine("*****************************************************************");
                    Console.WriteLine(arrayOfGSM[i].ToString());
                }

                Console.WriteLine(GSM.IPhone4S);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
