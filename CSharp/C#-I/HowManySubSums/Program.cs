using System;


using System;
using System.Collections.Generic;

class HowManySubSums
{

    static void SwapInts(int[] array, int position1, int position2)
    {
        //
        // Swaps elements in an array. Doesn't need to return a reference.
        //
        int temp = array[position1]; // Copy the first position's element
        array[position1] = array[position2]; // Assign to the second element
        array[position2] = temp; // Assign to the first element
    }
    static bool permutation(int[] arrr, int curr, int size)
    {
        if (curr == size)
        {
            int sum = 0;
            int sumBefore = 0;
            int[] Arr = new int[5];
            Queue<int> Q = new Queue<int>();
            for (int i = 0; i < 5; i++)
            {

                Q.Enqueue(arrr[i]);
                Q.CopyTo(Arr, 0);
                for (int j = 0; j < Q.Count; j++)
                {
                    sum = sum + Arr[j];
                }
                if (sum == 0)
                {
                    for (int k = 0; k < Q.Count; k++)
                    {
                        Console.Write("({0})+", Arr[k]);
                    }
                    Console.Write("=0");
                    Console.WriteLine();
                    return true;
                }
                if (sumBefore < sum && sumBefore != 0)
                {
                    Q.Dequeue();
                }
                sumBefore = sum;
                sum = 0;

            }
        }
        else
        {
            for (int i = curr; i < size; i++)
            {
                SwapInts(arrr, curr, i);
                if (permutation(arrr, curr + 1, size))
                {
                    return true;
                }
                SwapInts(arrr, curr, i);
            }
        }

        return false;

    }
    static void Main(string[] args)
    {
        int sum = int.Parse(Console.ReadLine());

        int N = int.Parse(Console.ReadLine());

        int countOfFoundSubSums = 0;

        int[] array = new int[N];

        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        if (permutation(array, 0, N - 1))
        {
            System.Console.WriteLine(); 
        }
     
    }
}

