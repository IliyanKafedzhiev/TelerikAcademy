using System;

class DecimalToHexadecimal
{
    static void ReverseString(ref string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        s = arr.ToString();
    }
    static void Main(string[] args)
    {
        int decimalNum = int.Parse(Console.ReadLine());
        string hexadecimalPresentation = " ";
        while (decimalNum != 0)
        {
            if (decimalNum % 16 > 9)
            {
                switch (decimalNum % 16)
                {
                    case 10:
                        hexadecimalPresentation += 'A';
                        break;
                    case 11:
                        hexadecimalPresentation += 'B';
                        break;
                    case 12:
                        hexadecimalPresentation += 'C';
                        break;
                    case 13:
                        hexadecimalPresentation += 'D';
                        break;
                    case 14:
                        hexadecimalPresentation += 'E';
                        break;
                    case 15:
                        hexadecimalPresentation += 'F';
                        break;
                    default:
                        break;
                }
            }
            else
            {
                hexadecimalPresentation += decimalNum % 16;
            }
            decimalNum /= 16;
        }
        hexadecimalPresentation += "x0";
        char[] arr = hexadecimalPresentation.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine(arr);
    }
}

