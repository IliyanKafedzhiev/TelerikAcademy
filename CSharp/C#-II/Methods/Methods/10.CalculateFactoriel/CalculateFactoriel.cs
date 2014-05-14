//Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 


using System;
using System.Numerics;

class CalculateFactoriel
{
    static BigInteger Factorial(int n)
    {
        BigInteger result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(n));
    }
}

