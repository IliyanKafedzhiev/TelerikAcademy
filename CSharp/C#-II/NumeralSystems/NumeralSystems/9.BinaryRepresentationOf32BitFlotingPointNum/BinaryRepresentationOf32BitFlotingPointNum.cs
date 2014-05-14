using System;
using System.Globalization;
using System.Text;


class BinaryRepresentationOf32BitFlotingPointNum
{
    static string DecimalToBinary(int decimalNum)
    {
        string binaryPresentation = "";
        int i = 0;
        while (i < 8)
        {
            binaryPresentation += decimalNum % 2;
            decimalNum /= 2;
            i++;
        }
        char[] arr = binaryPresentation.ToCharArray();
        Array.Reverse(arr);

        return new string(arr);
    }
    static void Main(string[] args)
    {
        float num = float.Parse(Console.ReadLine());
        bool sign = true;
        if (num > 0)
        {
            sign = true; //positive
        }
        else
        {
            sign = false;  //negative
            num *= -1;
        }
        int power = 0;
        while (num > 2)
        {
            num /= 2;
            power++;
        }
        while (num < 1)
        {
            num *= 2;
            power--;
        }
        int exponentInDecimal = 127 + power ;
        if (sign)
        {
            Console.Write("0.");
        }
        else
        {
            Console.Write("1.");
        }
        Console.Write(DecimalToBinary(exponentInDecimal));
        Console.Write(".");
       
        num = num - 1;
        int bits = 0;
        while (true)
        {

            num = num * 2;
            
            if (num < 1 || num > 2)
            {
                Console.Write("0");
            }
            else
            {
                Console.Write("1");
                num -= 1;
            }
            bits++;
            if (bits == 23)
            {
                break;
            }
        }
    }
}