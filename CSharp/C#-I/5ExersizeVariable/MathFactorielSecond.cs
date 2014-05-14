using System;
using System.Numerics;
class MathFactorielSecond
{
    static void Main()
    {
        UInt64 N;
        UInt64 K;
        Console.WriteLine("Input first N");
        N = UInt64.Parse(Console.ReadLine());
        Console.WriteLine("Input second K");
        K = UInt64.Parse(Console.ReadLine());
        if (N >= K)
        {
            Console.WriteLine("Erorr Input");
        }
        else
        {
            BigInteger Result = 1 ;
            for (UInt64 i = K - N; i <= K; i++)
            {
                Result =Result * i;
            }
            for (UInt64 i = 1; i <= N; i++)
            {
                Result *= i;
            }
            Console.WriteLine("Result is:{0}", Result);
        }
        
    }
}
