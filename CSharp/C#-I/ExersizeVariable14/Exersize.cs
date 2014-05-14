using System;
class Exersize
{
    static void Main()
    {
        Console.WriteLine("Input the integer number");

        uint n = uint.Parse(Console.ReadLine());

        Console.WriteLine("input how many bits you want to exchange");

        byte k = byte.Parse(Console.ReadLine());

        Console.WriteLine("Input the begin of first sequences");

        byte p = byte.Parse(Console.ReadLine());

        Console.WriteLine("Input the begin of second sequences");

        byte q = byte.Parse(Console.ReadLine());

        Console.WriteLine("Integer before:" + Convert.ToString(n, 2).PadLeft(32, '0'));

        uint valueOfPositionPbits=0 ;

        for (int i = 0; i < 32; i++)
        {
            valueOfPositionPbits += (uint)Math.Pow(2,k-1);
            if (k-1==0)
            {
                break;
            }
            k--;
        }

        uint valueofPositionQbits = valueOfPositionPbits;

        valueOfPositionPbits <<= p;

        valueofPositionQbits <<= q;

        uint secondValueOfPbits = valueOfPositionPbits;

        uint secondValueOfQbits = valueofPositionQbits;

        valueOfPositionPbits  &= n;

        valueofPositionQbits &= n;

        n &= (~secondValueOfPbits); //reset bits in number 

        n &= (~secondValueOfQbits); //reset bits in number

        valueOfPositionPbits <<= q-p;

        valueofPositionQbits >>= q-p;

        n |= valueofPositionQbits;

        n |= valueOfPositionPbits;

        Console.WriteLine("Integer after :" + Convert.ToString(n, 2).PadLeft(32, '0'));
    }
}
