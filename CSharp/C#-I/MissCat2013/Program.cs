using System;

class MissCat2013
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        int[] array = new int[N];

        int[] cats = new int[10];
        for (long i = 0; i < 10; i++)
        {
            cats[i] = 0;
        }

        for (long i = 0; i < N; i++)
        {
            array[i]=int.Parse(Console.ReadLine());
            cats[array[i]-1]++;
        }
        int maxVotes = 0;
        for (int i = 0; i < 10; i++)
        {
            if (maxVotes < cats[i])
            {
                maxVotes = cats[i];
            }
        }
        for (int i = 0; i < 10; i++)
        {
            if (cats[i] == maxVotes)
            {
                Console.WriteLine(i+1);
                i = i + 10;
            }
        }
        

    }
}

