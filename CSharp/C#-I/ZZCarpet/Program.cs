using System;


class Carpet
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int startDotsLeftRight = n / 2 - 1;

        int blocks = 0;

        for (int i  = 0; i  < n/2 ; i ++)
        {
            Console.Write(new string ('.', startDotsLeftRight));

            for (int j = 0; j < blocks; j++)
            {
                Console.Write("/ ");
            }


            if (i % 2 == 0  )
            {
                Console.Write('/');
                Console.Write('\\');
            }

            for (int j = 0; j < blocks; j++)
            {
                Console.Write(" \\");
            }
           

            Console.Write(new string('.', startDotsLeftRight));

            Console.WriteLine();

            startDotsLeftRight--;

            if (i % 2 == 0 && i+1 < n/2)
            {
                blocks++;
            }
        }
        startDotsLeftRight++;
        

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', startDotsLeftRight));

            for (int j = 0; j < blocks; j++)
            {
                Console.Write("\\ ");
            }


            if ((n/2) % 2 == 1 && i == 0)
            {
                Console.Write('\\');
                Console.Write('/');

            }
            if ((n/2) % 2 == 1)
            {
                if (i % 2 == 0 && i != 0)
                {
                    Console.Write('\\');
                    Console.Write('/');
                }
            }
            else
            {
                if (i % 2 != 0 && i != 0)
                {
                    Console.Write('\\');
                    Console.Write('/');
                }
            }
            

            for (int j = 0; j < blocks; j++)
            {
                Console.Write(" /");
            }
           


            Console.Write(new string('.', startDotsLeftRight));

            Console.WriteLine();

            startDotsLeftRight++;


            if ((n/2) % 2 == 1)
	        {
                if (i % 2 != 0)
                {
                    blocks--;
                }
	        }
            else
            {
                if (i % 2 == 0)
                {
                    blocks--;
                }
            }
            
        }
        
    }
}
