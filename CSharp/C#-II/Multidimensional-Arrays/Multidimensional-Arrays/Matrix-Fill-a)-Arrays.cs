using System;

class MatriixFill
{
    static void Main ()
    {
        Console.WriteLine("Input n:");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[j, i] = counter;
                counter++ ;   
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}

