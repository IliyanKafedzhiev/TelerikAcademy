//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line,
//column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix

using System;

class NeighborOfStringsInMatrix
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        string [,] matrix = new string [rows,cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
        }

        string direction = "down";
        int[] cordinates = new int[4];

        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < cols - 1; j++)
            {
                if (matrix[i,j] == matrix[i+1,j+1])
                {
                    
                }


            }
        }


    }
}

