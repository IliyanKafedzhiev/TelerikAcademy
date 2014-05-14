//Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class GetMaxMethod
{
    static int GetMax(int first, int second)
    {
        return (first >= second)?first:second;
    }

    static void Main(string[] args)
    {
        int[] array = new int[3];

        for (int i = 0; i < 3; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int max = GetMax(array[0], array[1]);
        max = GetMax(max, array[2]);
        Console.WriteLine(max);
    }
}

