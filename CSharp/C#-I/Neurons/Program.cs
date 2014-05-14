using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> inputs = new List<int>();
        int input;
        bool trueInput = true;
        while (trueInput)
        {

            input = int.Parse(Console.ReadLine());
            if (input == -1 )
            {
                trueInput = false; 
            }
            else
            {
                inputs.Add(input);
            }
        }

        bool[,] matrix = new bool[inputs.Count, 32];

        for (int i = 0; i < inputs.Count ; i++)
        {
            for (int j = 31
                ; j > -1
                ; j--)
            {
                matrix[i, j] = (((inputs [i] & (1 << j)) >> j) == 0) ? false : true;
                Console.Write(
                    (matrix[i, j])?1:0
                    );
            }
            Console.WriteLine();
        }
        
        int [,] matrixForLearnigTrack



            = new int [inputs.Count,32];
        for (int i = 0; i < inputs.Count; i++)
        {
            for (int j = 31
                ; j > -1
                ; j--)
            {
                matrixForLearnigTrack[i, j] = 0;
            }
            
        }

        bool changeMatrix = false;

        int Row = 0;
        int Cow = 0;

        string direction = "right";
        int startedRow = 0;
        int startedCol = 0;

        while (changeMatrix)
        {
            if (matrix[Row, Cow] == true && matrix[Row, Cow + 1
                ] == true)
            {
                startedCol = Cow;
                startedRow = Row;
                direction = "right";
            }
            else if (matrix[Row, Cow] == true && matrix[Row + 1, Cow + 1] == true)
            {
                direction =
                "downRight";
            }
            else if (matrix[Row, Cow] == true && matrix[Row + 1, Cow] == true)
            {
                direction = "down";
            }
            else if (matrix[Row, Cow] == true && matrix[Row + 1, Cow - 1] == true) 
            {
                direction = "downLeft";
            }
            else if (direction == "downRight" && matrix[Row + 1, Cow + 1] == true)
            {
                direction =
                "downRight";
            }
            else if (direction == "downRight" && matrix[Row + 1, Cow] == true)
            {
                direction = "down";
            }
            else if (direction == "downRight" && matrix[Row + 1, Cow - 1] == true)
            {
                direction = "downLeft";
            }
            else if (direction == "downRight" && matrix [Row,Cow +1] == true)
	        {
                direction = "right";
	        }
            else if (direction == "downRight" && matrix[Row, Cow - 1] == true)
            {
                direction = "left";
            }












            if (direction == "right")
            {
                Cow++;
            }
            if (direction == "downRight")
            {
                Cow++;
                Row++;
            }
            if (direction == "down")
            {
                Row++;
            }
            if (direction == "downLeft")
            {
                Row++;
                Cow--;
            }
            if (direction == "left")
            {
                Cow--;
            }
            break;
        }

    }
}

