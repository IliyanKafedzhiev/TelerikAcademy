using System;

class BinaryToHexadecimal
{
    static string BynaryToHexadecimalDirectly(string binaryNum)
    {
        string hexadecimal = "";
        for (int i = binaryNum.Length-1; i > -1 ;)
        {
            string currVal = "";
            for (int j = 0; j < 4 ; j++)
            {
                if (i < 0)
                {
                    currVal += "0";
                }
                else
                {
                    currVal += binaryNum[i];
                }
                i--;
            }
            char[] array = currVal.ToCharArray();
            Array.Reverse(array);
            currVal = new string(array);
            switch (currVal)
            {
                case "0000":
                    currVal = "0";
                    break;
                case "0001":
                    currVal = "1";
                    break;
                case "0010":
                    currVal = "2";
                    break;
                case "0011":
                    currVal = "3";
                    break;
                case "0100":
                    currVal = "4";
                    break;
                case "0101":
                    currVal = "5";
                    break;
                case "0110":
                    currVal = "6";
                    break;
                case "0111":
                    currVal = "7";
                    break;
                case "1000":
                    currVal = "8";
                    break;
                case "1001":
                    currVal = "9";
                    break;
                case "1010":
                    currVal = "A";
                    break;
                case "1011":
                    currVal = "B";
                    break;
                case "1100":
                    currVal = "C";
                    break;
                case "1101":
                    currVal = "D";
                    break;
                case "1110":
                    currVal = "E";
                    break;
                case "1111":
                    currVal = "F";
                    break;
                default:
                    break;
            }
            hexadecimal += currVal;
        }
        char[] result = hexadecimal.ToCharArray();
        Array.Reverse(result);
        return "0x" + new string(result);
    }
    static void Main(string[] args)
    {
        string binary = Console.ReadLine();
        Console.WriteLine(BynaryToHexadecimalDirectly(binary));
    }
}

