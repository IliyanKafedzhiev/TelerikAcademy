using System;
class MathFactoriel
{
    static void Main()
    {
        UInt64 N;
        UInt64 F;
        Console.WriteLine("Input first N");
        N = UInt64.Parse(Console.ReadLine());
        Console.WriteLine("Input second F");
        F = UInt64.Parse(Console.ReadLine());
        int tmp;
        if (N <= F)
        {
            Console.WriteLine("Erorr Input");
        }
        else
        {
            UInt64 Result=1;
            for (UInt64 i = F + 1; i < N + 1; i++)
            {
                Result *= i;
            }
            Console.WriteLine("Result is:{0}",Result);
        }
        
    }

}
