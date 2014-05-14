using System;

class NumeralSystems
{
    static void ReverseString(ref string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        s = arr.ToString();
    }
    static string DecimalToBinary(int decimalNum)
    {
        string binaryPresentation = "";
        while (decimalNum != 0)
        {
            binaryPresentation += decimalNum % 2;
            decimalNum /= 2;
        }
        char[] arr = binaryPresentation.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
    static void Main(string[] args)
    {
        int decimalNum = int.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToBinary(decimalNum));
    }
}