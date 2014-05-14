using System;
class Exersize
{
    static void Main()
    {
        int firstCheckInteger;
        Console.WriteLine("Input first number");
        firstCheckInteger = int.Parse(Console.ReadLine());
        int secondCheckInteger;
        Console.WriteLine("Input second number");
        secondCheckInteger = int.Parse(Console.ReadLine());
        int counterP = 0;
        for (int i = firstCheckInteger; i <=  secondCheckInteger; i++)
        {
            if (i % 5 == 0)
            {
                counterP++;
            }
        }
        Console.WriteLine("P={0}",counterP);
        
    }
}
