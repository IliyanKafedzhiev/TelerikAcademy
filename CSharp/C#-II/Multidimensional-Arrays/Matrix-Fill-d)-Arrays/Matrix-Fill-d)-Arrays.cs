using System;

class MatriixFill
{
    static void Main()
    {
        Console.WriteLine("Input n:");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 1;
        int row = 0;
        int coll = 0;
        string direction = "down";
        int cicle = 0;
        //fill matrix
        while (true)
        {
            matrix[row, coll] = counter;

            if (direction == "down" )
            {
                row++;
            }
            else if (direction == "right")
            {
                coll++;
            }
            else if (direction == "up")
            {
                row--;
            }
            else if (direction == "left")
            {
                coll--;
            }

            counter++;
            if (counter > n * n)
            {
                break;
            }

            // change direction

            if (direction == "down" && row == n - cicle)
            {
                row--;
                coll++;
                direction = "right";
            }
            else if (direction == "right" && coll == n - cicle)
            {
                coll--;
                row--;
                direction = "up";
            }
            else if (direction == "up" && row == cicle-1 )
            {
                row++;
                coll--;
                direction = "left";
            }
            else if (direction == "left" && coll == cicle )
            {
                coll++;
                row++;
                direction = "down";
                cicle++;
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
