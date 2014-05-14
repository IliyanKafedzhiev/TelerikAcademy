//Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".

using System;

class LastDigitToStringMethod
{
    static string StringFromInteger(int integer)
    {
        int digit = integer % 10;
        switch (digit)
        {
            case 0:
                return "zero";
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            default:
                break;
        }
        return "None";
    }
    static void Main(string[] args)
    {
        int integer = int.Parse(Console.ReadLine());
        Console.WriteLine(StringFromInteger(integer));
    }
}

