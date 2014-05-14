using System;

    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int dotsLeftRight = N / 2 - 1;
            int innerDots = 0;

            for (int i = 0; i < N/2   ; i++)
            {
                Console.Write(new string('.', dotsLeftRight));
                Console.Write('#');
                Console.Write(new string('.', innerDots));
                Console.Write('#');
                Console.Write(new string('.', dotsLeftRight));
                dotsLeftRight--;
                innerDots += 2;
                Console.WriteLine();
            }
            dotsLeftRight++;
            innerDots -= 2;
            for (int i = 0; i < (N/2)/2
                ; i++)
            {
                Console.Write(new string('.', dotsLeftRight));
                Console.Write('#');
                Console.Write(new string('.', innerDots));
                Console.Write('#');
                Console.Write(new string('.', dotsLeftRight));
                dotsLeftRight++;
                innerDots -= 2;
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', N));
            dotsLeftRight = 0;
            int 
            bachslashes = N / 2;
            for (int i = 0; i < N/2   ; i++)
            {
                Console.Write(new string('.', dotsLeftRight));
                Console.Write(new string('\\', bachslashes));
                Console.Write(new string('/', bachslashes));

                Console.Write(new string('.', dotsLeftRight));
                Console.WriteLine();
                dotsLeftRight++;
                bachslashes--;

            }

        }
    }

