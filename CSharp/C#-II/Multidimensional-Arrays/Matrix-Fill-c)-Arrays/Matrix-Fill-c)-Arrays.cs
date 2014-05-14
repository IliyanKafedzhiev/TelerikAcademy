using System;

class MatriixFill
{
    static void Main()
    {
        Console.WriteLine("Input n:");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 1;
        int row = n-1;
        int coll = 0;
        int currentRow = n-1;
        int currentCol = 0;
        //fill matrix
        while (true)
        {
            matrix[row, coll] = counter;
            row++;
            coll++;
            if (row > n - 1 )
            {
                currentRow--;
                if (currentRow == 0)
                {
                    currentCol = 0; 
                    
                }
                if (currentRow < 0)
                {
                    currentCol++;
                }
                if (currentRow < 0)
                {
                    currentRow = 0;
                }
                row = currentRow;
                coll = currentCol;   

            }
            if (coll > n - 1)
            {
                coll = ++currentCol;
                row = 0;
            }
            
            counter++;
            if (counter> n * n)
            {
                break;
            }
        }


        //print matrix
        for (int i = 0; i < n; i++)
        {
            for (int z = 0; z < n; z++)
            {
                Console.Write(matrix[i, z] + " ");
            }
            Console.WriteLine();
        }
    }
}
