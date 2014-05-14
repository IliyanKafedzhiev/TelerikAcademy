using System;

class CharArrayComparator
{
    static void Main(string[] args)
    {
        char[] firstString;
        char[] secondString;
        Console.WriteLine("Input the length of Arrays of char");
        int length = int.Parse(Console.ReadLine());
        firstString = new char[length];
        secondString = new char[length];
        Console.WriteLine("Input first array of char");
        for (int i = 0; i < length; i++)
        {
            firstString[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("Input second array of char");
        for (int i = 0; i < length; i++)
        {
            secondString[i] = char.Parse(Console.ReadLine());
        }
        if (isEqal(firstString,secondString,length))
        {
            Console.WriteLine("Arrays are equal");
        }
        else
        {
            Console.WriteLine("Arrays are not equal");
        }
    }
    static bool isEqal(char[] first, char[] second,int length)
    {
        for (int i = 0; i < length; i++)
        {
            if (first[i] != second[i])
            {
                return false;
            }
        }
        return true;
    }
}

