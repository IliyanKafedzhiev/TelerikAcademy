using System;
using System.Numerics;

 class ZeroInFact
    {
        static void Main()
        {
            Console.WriteLine("Input N:");
            int N;
            double zeros = 0;
            N = int.Parse(Console.ReadLine());
            for (int i= 1;  Math.Pow(5,i) <= N; i++)
            {
                zeros = zeros + (N / (int)Math.Pow(5,i));
            }
            Console.WriteLine("Number of zeros is:{0}",zeros);
        }
    }

