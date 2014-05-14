using System;
using System.Numerics;

class CatalanNumbs
{
    static void Main()
    {
        int n;
        Console.WriteLine("Input n:");
        n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {

            Console.WriteLine("Error");
            return;
        }
        BigInteger numerator = 1;
        for (int i = 2 * n ; i > n; i--)
        {
            numerator = numerator * i;
        }
        BigInteger denumerator = 1;
        for (int i =  n + 1; i > 0; i--)
        {
            denumerator = denumerator * i;
        }
        Console.WriteLine("Catalan number {0} is :{1}  ",n,numerator / denumerator);

    }
    
}
