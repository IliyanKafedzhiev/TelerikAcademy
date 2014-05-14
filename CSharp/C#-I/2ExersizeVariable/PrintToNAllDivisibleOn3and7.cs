using System;
class PrintToNAllDivisibleOn3and7
{
    static void Main()
    {
        int x;
        Console.WriteLine("Input N");
        x = int.Parse(Console.ReadLine());
        if (x < 1)
        {
            Console.WriteLine("Erorr INPUT!");
        }
        for (int i = 0; i < x; i++)
        {
            if ((i % 3) == 0 && (i % 7) == 0)
            {
                Console.WriteLine(" {0} ", i);
            }
        }
        
    }
}
