using System;
class SumOfFib
{
    static void Main()
    {
        int N;
        Console.WriteLine("Input N");
        N = int.Parse(Console.ReadLine());
        if (N<1)
        {
            Console.WriteLine("Erorr Input");
            return;
        }
        if (N == 1)
        {
            Console.WriteLine("Sum is 0");
            return;
        }
        if (N == 2)
        {
            Console.WriteLine("Sum is 1");
            return;
        }
        if (N == 3)
        {
            Console.WriteLine("Sum is 2");
            return;
        }
        int second = 1;
        int third = 1;
        int sum = 2;
        int tmp;
        for (int i = 3; i < N; i++)
        {
            tmp = third + second;
            second = third;
            third = tmp;
            sum += tmp;
        }
        Console.WriteLine("Sum is :{0}",sum);
    }
}
