using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ChristmasTree
{
    static void Main()
    {
        Console.WriteLine("Input :) :");
        int N = int.Parse(Console.ReadLine());
        int dotsOnLineLeftRight = N - 2;
        int stars = 1;
        for (int i = 1; i < N; i++)
        {
            Console.Write(new string('.', dotsOnLineLeftRight));
            Console.Write(new string('*',stars));
            Console.Write(new string('.', dotsOnLineLeftRight));
            Console.WriteLine();
            dotsOnLineLeftRight--;
            stars += 2;
        }
        dotsOnLineLeftRight = N - 2;
        stars = 1;
        Console.Write(new string('.', dotsOnLineLeftRight));
        Console.Write(new string('*', stars));
        Console.Write(new string('.', dotsOnLineLeftRight));
    }
}
