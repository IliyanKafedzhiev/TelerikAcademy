using System;
using System.Numerics;

class Sum
{
    static void Main()
    {
        int N;
        int X;
        Console.WriteLine("intput N:");
        N = int.Parse(Console.ReadLine());
        Console.WriteLine("intput X:");
        X = int.Parse(Console.ReadLine());
        decimal sum = 1;
        double fact =1;
        for (int i = 1; i <= N; i++)
        {
            fact *=i;
            sum += (decimal)( fact / Math.Pow((double)X, i) );
        }
        Console.WriteLine("Sum is : {0}",sum);
    }
}
