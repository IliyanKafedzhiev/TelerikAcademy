using System;

class Program
{
    static string ConvertToBinary(short x)
    {
        char[] bits = new char[16];
        int i = 0;

        while (x != 0)
        {
            bits[i++] = (x & 1) == 1 ? '1' : '0';
            x >>= 1;
        }

        Array.Reverse(bits, 0, i);
        return new string(bits);
    }
    static void Main(string[] args)
    {
        short num = short.Parse(Console.ReadLine());
        
        Console.WriteLine(ConvertToBinary(num));
    }
}

