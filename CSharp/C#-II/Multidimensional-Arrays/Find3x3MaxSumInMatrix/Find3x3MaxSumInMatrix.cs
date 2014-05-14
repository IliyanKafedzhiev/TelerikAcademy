//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements



using System;

class find3x3MaxSum
{
    static void Main(string[] args)
    {
        int currentSum = 0;
        int limits = 3;
        int[,] findedMatrix = new int[limits, limits];

        int rows = int.Parse(Console.ReadLine());
        int coll = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, coll];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < coll; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        if (rows < limits || coll < limits)
        {
            Console.WriteLine("Not Found");
        }
        else if (rows == limits && coll == limits)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    findedMatrix[i, j] = matrix[i, j];
                }
            }
        }
        else if (true)
        {
            for (int i = 0; i <= rows-limits; i++)
            {
                for (int j = 0; j <= coll-limits; j++)
                {
                    int sumBefore = currentSum;
                    currentSum = 0;

                    for (int crawlRows = i; crawlRows < i+3 ; crawlRows++)
                    {
                        for (int crawlCols = j; crawlCols < j+3; crawlCols++)
                        {
                            currentSum += matrix[crawlRows, crawlCols];

                        }
                    }
                    // fill findet matrix 
                    if (currentSum > sumBefore)
                    {
                        int curRows = 0; 
                        int curCols = 0;
                        for (int crawlRows = i; crawlRows < i + 3; crawlRows++)
                        {
                            for (int crawlCols = j; crawlCols < j + 3; crawlCols++)
                            {
                                findedMatrix[curRows,curCols]= matrix[crawlRows, crawlCols];
                                curCols++;

                            }
                            curRows++;
                            curCols = 0;
                        }
                    }


                }
            }
        }



        //print finded matrix

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(findedMatrix[i, j] + "  ");
            }
            Console.WriteLine();
        }
       
    }
}
