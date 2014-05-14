using System;

class Program
{
    static void Main(string[] args)
    {
        string binaryNumber = Console.ReadLine();
        double decimalNumber = 0;
        int power = 0;
        for (int i = binaryNumber.Length - 1; i > -1; i--)
        {
            string bit = binaryNumber[i].ToString();
            decimalNumber += int.Parse(bit) * Math.Pow(2,power);
            power++;
        }
        Console.WriteLine(decimalNumber);
    }
}
