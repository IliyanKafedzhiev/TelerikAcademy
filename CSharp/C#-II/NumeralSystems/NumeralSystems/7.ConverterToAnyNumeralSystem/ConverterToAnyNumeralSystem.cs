using System;

class ConverterToAnyNumeralSystem
{
    static int ConverterToDecimal(string number, int baseOnNumber)
    {
        double decimalNumber = 0;
        int power = 0;
        for (int i = number.Length - 1; i > -1; i--)
        {
            string bit = number[i].ToString();

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
            decimalNumber += currValue * Math.Pow(baseOnNumber, power);
            power++;
        }
        return (int)decimalNumber;
    }
    static string ConverterFromDecimalToAnyOther(int decimalNum, int baseToNewNum)
    {
        
        string newNumPresentation = "";
        while (decimalNum != 0)
        {
            if (decimalNum % baseToNewNum > 9)
            {
                switch (decimalNum % baseToNewNum)
                {
                    case 10:
                        newNumPresentation += 'A';
                        break;
                    case 11:
                        newNumPresentation += 'B';
                        break;
                    case 12:
                        newNumPresentation += 'C';
                        break;
                    case 13:
                        newNumPresentation += 'D';
                        break;
                    case 14:
                        newNumPresentation += 'E';
                        break;
                    case 15:
                        newNumPresentation += 'F';
                        break;
                    default:
                        break;
                }
            }
            else
            {
                newNumPresentation += decimalNum % baseToNewNum;
            }
            decimalNum /= baseToNewNum;
        }
        if (baseToNewNum == 16)
        {
            newNumPresentation += "x0";
        }
        
        char[] arr = newNumPresentation.ToCharArray();
        Array.Reverse(arr);
        return new string (arr);
    }
    static string Converter(string number, int baseOnNumber, int baseToNewNum)
    {
        int decimalPresentation = ConverterToDecimal(number, baseOnNumber);
        if (baseToNewNum == 10)
        {
            return decimalPresentation.ToString();
        }
        return ConverterFromDecimalToAnyOther(decimalPresentation,baseToNewNum);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Input The Base of the numerical system of your number ,please :");
        int baseOnNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please Input your num:");
        string numToConvert = Console.ReadLine();
        Console.WriteLine("Please Input a new base that you want to convert your number ,Please :");
        int baseToNewNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Your result is : {0}  Thank you ! ",Converter(numToConvert,baseOnNumber,baseToNewNum));
    }
}

