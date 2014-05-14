using System;

class ArrayMultiplayIndexBy5
{
    static void Main(string[] args)
    {
        int[] array = new int[20];
        for (int i = 0; i < 20; i++)
        {
            array[i] = i * 5;
            Console.WriteLine(array[i]);
        }
    }
}

