using System;

class MaximalSequenceInArray
{
    static void Main()
    {
        Console.WriteLine("Input the legnth");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Input {0} elemnts",i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int counter = 0;
        int oldCounter = 0;
        for (int i = 0; i < length; i++)
        {
            counter = 0;
            for (int j = i; j < length; j++)
            {
                if (array[i] == array[j])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            if (oldCounter < counter)
            {
                oldCounter = counter;
            }
        }
        Console.WriteLine(oldCounter);
    }
}

