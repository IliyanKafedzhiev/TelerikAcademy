using System;

class HexadecimalToDecimal
{
    static int HexadecimalToDecimalMethod( string hexadecimalPresentation)
    {
        double decimalNumber = 0;
        int power = 0;
        for (int i = hexadecimalPresentation.Length - 1; i > -1; i--)
        {
            string bit = hexadecimalPresentation[i].ToString();

            int currValue;
            switch (bit)
            {
                case "A":
                    currValue = 10;
                    break;
                case "B":
                    currValue = 11;
                    break;
                case "C":
                    currValue = 12;
                    break;
                case "D":
                    currValue = 13;
                    break;
                case "E":
                    currValue = 14;
                    break;
                case "F":
                    currValue = 15;
                    break;
                default:
                    currValue = int.Parse(bit);
                    break;
            }
            decimalNumber += currValue * Math.Pow(16, power);
            power++;
        }
        return (int)decimalNumber;
    }
    static void Main(string[] args)
    {
        string hexa = Console.ReadLine ();
        Console.WriteLine(HexadecimalToDecimalMethod( hexa ));
    }
}

