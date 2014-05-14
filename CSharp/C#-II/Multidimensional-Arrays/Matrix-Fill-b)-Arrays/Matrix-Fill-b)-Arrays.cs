using System;

class MatriixFill
{
    static void Main()
    {
        Console.WriteLine("Input n:");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 1;
        int k = 0;
        int j = 0;
        while (true)
        {
            matrix[k, j] = counter;
            k++;
            if (k >= (n))
            {
                j++;
                k = 0;
            }
            if (j >= n)
            {
                break;
            }
            counter++;
        }
        for (int i = 0; i < n; i++)
        {
            for (int z= 0; z < n; z++)
            {
                Console.Write(matrix[i, z] + " ");
            }
            Console.WriteLine();
        }
    }
}
