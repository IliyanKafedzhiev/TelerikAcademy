using System;

    class Program
    {
        static void Main()
        {
            int rounds = int.Parse(Console.ReadLine());

            int[] drunkedNums = new int[rounds];

            for (int i = 0; i < rounds; i++)
            {
                drunkedNums[i] = Math.Abs(
                    int.Parse(Console.ReadLine()));
            }
            int V = 0;
            int M = 0;

            for (int i = 0; i < rounds; i++)
            {
                int howManyDigits = 0;
                int[] digits = new int[17];


                for (int j = 0; j < 17;
                    j++)
                {
                    digits[j] = 0;
                }

                for (int j = 0 ; j < 17; j ++  )
                {
                    digits[j] = drunkedNums[i] % 10;
                    drunkedNums[i] /= 10;
                }

                for (int j = 8; j > -1    ; j--)
                {
                    if (digits[j]!=0)
                    {
                        howManyDigits = j + 1;
                        j = -1;
                    }
                }
                if (howManyDigits%2==0)
                {
                    for (int j = 0; j < howManyDigits/2 ; j++)
                    {
                        V += digits[j];
                    }
                    for (int j = howManyDigits/2 
                        ; j < howManyDigits
                        ; j++)
                    {
                        M += digits[j];
                    }

                }
                else
                {
                    for (int j = 0; j < howManyDigits / 2 + 1
                        ; j++)
                    {
                        V += digits[j];
                    }
                    for (int j = howManyDigits / 2
                        ; j < howManyDigits
                        ; j++)
                    {
                        M += digits[j];
                    }
                }

            }

            if (M > V)
            {
                Console.WriteLine("M {0}", M - V);
            }
            else if (V>M)
            {
                Console.WriteLine("V {0}", V - M);
            }
            else if (V==M)
            {
                Console.WriteLine("No {0}", V + M);
            }

        }
    }
