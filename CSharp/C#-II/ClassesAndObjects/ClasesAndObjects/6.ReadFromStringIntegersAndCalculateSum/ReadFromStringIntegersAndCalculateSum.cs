using System;

class ReadFromStringIntegersAndCalculateSum
{
    static int SumOfIntegerByString(string integersString)
    {
        int sum = 0;
        int positioning = 0;
        for (int i = 0; i < integersString.Length; i++)
        {
            if (integersString[i] == ' ' || i == integersString.Length-1)
            {
                char [] currentNum = new char [i - positioning + 1];
                int counter = 0;
                for (int j = positioning; j <= i ; j++)
                {
                    currentNum[counter++] = integersString[j];
                }
                string currentNumInString = new string(currentNum);
                sum += int.Parse(currentNumInString);
                positioning = i + 1;
            }
        }
        return sum;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(SumOfIntegerByString("12 12 123 432 444"));
    }
}

