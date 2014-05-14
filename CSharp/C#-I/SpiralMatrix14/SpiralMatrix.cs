using System;


class SpiralMatrix
{
    static void Main()
    {
        int N;
        Console.WriteLine("Input N ");
        N = int.Parse(Console.ReadLine());

        int [,]conteiner = new int [N,N]; //matrix

        int counter = 1; // counter 

        int rows = N;
        int colums = N;

        int startrows = 0;
        int startcol = 0;

        while (counter <= N * N) 
        {
            
            for (int i = startcol; i < colums; i++)
            {
                conteiner[startrows, i] = counter;
                counter++;
            }
            startrows++;
            for (int i = startrows; i < rows; i++)
            {
                conteiner[i, colums - 1] = counter;
                counter++;
            }

            for (int i = colums-2; i >= startcol ; i--)
            {
                conteiner[rows - 1, i] = counter;
                counter++;
            }
            for (int i = rows-2; i >= startrows; i--)
            {
                conteiner[i, startcol] = counter;
                counter++;
            }
            rows--;
            startcol++;
            colums--;
        }
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(" {0}",conteiner[i, j]);
            }
            Console.WriteLine();
        }
    }
}
