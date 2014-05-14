using System;


class QQWayByForest
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int rows = N * 2 - 1;

        int leftDots = 0;
        int rightDots = N - 1;
        bool changeWay = false;
        for (int i = 0; i < rows; i++)
        {
            Console.Write(new string ('.',leftDots));
            Console.Write('*');
            Console.Write(new string('.', rightDots));

            if (rightDots==0)
            {
                changeWay = true;
            }
            if (changeWay)
            {
                rightDots++;
                leftDots--;
            }
            else
            {
                rightDots--;
                leftDots++;
            }
            Console.WriteLine();
        }

    }
}

