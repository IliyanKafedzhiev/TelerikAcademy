using System;

class ReverseDigits
{
    static void ReverseDigit(ref int digit)
    {
        string digitString = digit.ToString();
        char[] arrayOfChar = new char[digitString.Length];
        for (int i = 0; i < digitString.Length ; i++)
        {
            arrayOfChar [i] = digitString[i];  
        }
        for (int i = 0; i < digitString.Length/2; i++)
        {
            char a = arrayOfChar[i];
            arrayOfChar[i] = arrayOfChar[digitString.Length - 1 - i];
            arrayOfChar[digitString.Length - 1 - i] = a;
        }
        string lastStrig = new string(arrayOfChar); 
        digit = int.Parse(lastStrig);
    }

    static void Main()
    {
        int digit = 234567;
        ReverseDigit(ref digit);
        Console.WriteLine(digit);
    }
}

