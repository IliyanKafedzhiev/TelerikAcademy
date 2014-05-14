using System;
class Exersize
{
    static void Main()
    {
        int n;
        Console.WriteLine("Input integer num N:");
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + ",");
        }
    }
}
