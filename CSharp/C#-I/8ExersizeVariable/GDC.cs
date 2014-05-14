using System;
class GDCe
{
    static int GCD(int a, int b)
    {
        int Remainder;

        while (b != 0)
        {
            Remainder = a % b;
            a = b;
            b = Remainder;
        }

        return a;
    }
    static void Main()
    {
        int a;
        int b;
        int gdc;
        Console.WriteLine("input first num:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("input first num:");
        b = int.Parse(Console.ReadLine());
        if (a == b)
        {   
            gdc = a;
        }
        else
        {
            gdc = GCD( a , b );
        }
        Console.WriteLine("GDC : {0}",gdc);
        
    }
}
