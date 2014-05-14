using System;

class CoffeeMachineCoints
{
    static void Main(string[] args)
    {
        int []coint= new int [5];

        for (int i = 0; i < 5; i++)
        {
             coint [i] = int.Parse(Console.ReadLine());
        }
        
        double
            amountFromDeveloper = double
            .Parse(Console.ReadLine
            ());

        double priceOfSelectedDrink = double.Parse(Console.ReadLine());

        if (amountFromDeveloper < priceOfSelectedDrink)
        {
            Console.WriteLine("More {0:0.00}",priceOfSelectedDrink - amountFromDeveloper);
        }
        else
        {
            double sumInMachine = 0;
            sumInMachine += 
                (coint[0] * (double)
                0.05);

            sumInMachine +=  (coint[1] * (double)
                0.10);

            sumInMachine +=  (coint[2] * (double)
                0.20);

            sumInMachine +=  (coint[3] * (double)
                0.50);

            sumInMachine +=  (coint[4] * (double)
                1.00);

            if (sumInMachine ==amountFromDeveloper && amountFromDeveloper == priceOfSelectedDrink)
            {
                Console.WriteLine("Yes 0.00");
            }
            else if (sumInMachine < (amountFromDeveloper - priceOfSelectedDrink))
            {
                Console.WriteLine("No {0:0.00}", (amountFromDeveloper - priceOfSelectedDrink) - sumInMachine);
            }
            else if (sumInMachine > (amountFromDeveloper - priceOfSelectedDrink ))
            {
                Console.WriteLine("Yes {0:0.00}", sumInMachine - (amountFromDeveloper - priceOfSelectedDrink));
            }
            


        }
    }
}

