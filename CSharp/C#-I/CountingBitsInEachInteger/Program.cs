using System;

class CountingBitsInEachInteger
{
    static void Main()
    {
        int B = int.Parse(Console.ReadLine());
        bool chekedBit = (B == 0)?false:true;

        int N = int.Parse(Console.ReadLine());

        uint[] array = new uint[N];
        int[] counteiner = new int[N];
        bool[,]matrix = new bool [N,32];
        for (int i = 0; i < N; i++)
        {
            counteiner[i] = 0;
        }
        for (int i = 0; i < N; i++)
        {
            array[i] = uint.Parse(Console.ReadLine());
        }
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < 32; j++)
            {
                matrix[i,j] = ( ((array[i] & (1 << j)) >> j ) == 0)?false:true  ;
            }
        }

        for (int i = 0; i < N; i++)
        {
            int lenght = 0;
            for (int j = 31; j > -1; j--)
            {
                if (matrix[i,j] == true)
                {
                    break;
                }
                else
                {
                    lenght++;
                }
            }
            lenght = 32 - lenght;
            for (int j = 0; j < lenght; j++)
            {
                if (matrix[i,j] == chekedBit)
                {
                    counteiner[i]++;
                }
            }
        }
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(counteiner[i]);
        }

    }
}

