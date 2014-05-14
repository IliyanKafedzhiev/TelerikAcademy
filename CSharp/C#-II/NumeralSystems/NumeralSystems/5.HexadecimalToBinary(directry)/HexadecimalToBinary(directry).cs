using System;

class Program
{
    static string DecimalToBinary(int decimalNum)
    {
        string binaryPresentation = " ";
        while (decimalNum != 0)
        {
            binaryPresentation += decimalNum % 2;
            decimalNum /= 2;
        }
        char[] arr = binaryPresentation.ToCharArray();
        Array.Reverse(arr);
        string result = new string(arr);
        return result;
    }
    static string HexadecimalToBinary(string Hexadecimal)
    {
        string binaryPresentation = "";
        for (int i = 0; i < Hexadecimal.Length; i++)
        {
            string currValue = Hexadecimal[i].ToString();
            switch (currValue)
            {
                case "0":
                    currValue = "0000";
                    break;
                case "1":
                    currValue = "0001";
                    break;
                case "2":
                    currValue = "0010";
                    break;
                case "3":
                    currValue = "0011";
                    break;
                case "4":
                    currValue = "0100";
                    break;
                case "5":
                    currValue = "0101";
                    break;
                case "6":
                    currValue = "0110";
                    break;
                case "7":
                    currValue = "0111";
                    break;
                case "8":
                    currValue = "1000";
                    break;
                case "9":
                    currValue = "1001";
                    break;
                case "A":
                    currValue = "1010";
                    break;
                case "B":
                    currValue = "1011";
                    break;
                case "C":
                    currValue = "1100";
                    break;
                case "D":
                    currValue = "1101";
                    break;
                case "E":
                    currValue = "1110";
                    break;
                case "F":
                    currValue = "1111";
                    break;
                default:
                    
                    break;
            }
            binaryPresentation += currValue;
        }

        return binaryPresentation;
    }
    static void Main(string[] args)
    {
        string hexa = Console.ReadLine();
        Console.WriteLine(HexadecimalToBinary(hexa));
    }
}

