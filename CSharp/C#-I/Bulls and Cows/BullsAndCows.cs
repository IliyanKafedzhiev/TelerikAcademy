using System;
using System.Collections.Generic;

class BullsAndCows
{
    static void Main(string[] args)
    {
        int secretNumber = int.Parse(Console.ReadLine());

        int secretNumToTry = secretNumber;

        int bulls = int.Parse(Console.ReadLine());

        int cows = int.Parse(Console.ReadLine());
        List<int> GuessNumbers
        = new List<int>();
        List<int> nums = new List<int>();

        for (int i = 0; i < 4; i++)
        {
            nums.Add(secretNumber % 10);
            secretNumber /= 10;
        }
        nums.Sort();
        for (int i = 0; i < nums.Count
            ; i++)
        {
            Console.WriteLine(nums[i]);
        }

        if (cows == 0)
        {
            if (bulls >= 4)
            {
                Console.WriteLine("No");
            }
            else if (bulls == 3)
            {
                for (int i = 0; i < 4; i++)
                {

                    for (int j = 1; j <= 9; j++)
                    {
                        int[] arr = new int[4];
                        for (int k = 0; k < 4; k++)
                        {
                            arr[k] = nums[k];
                        }
                        arr[i] = j;
                        int numForAdd = 0;
                        numForAdd += arr[3];
                        numForAdd += arr[2] * 10;
                        numForAdd += arr[1] * 100;
                        numForAdd += arr[0] * 1000;
                        if (numForAdd != secretNumToTry)
                        {
                            GuessNumbers.Add(numForAdd);
                        }

                    }
                }

            }
            else if (bulls == 2)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int z = 0; z < 4; z++)
                    {

                        for (int j = 1; j <= 9; j++)
                        {
                            for (int p = 1; p < 10; p++)
                            {


                                int[] arr = new int[4];
                                for (int k = 0; k < 4; k++)
                                {
                                    arr[k] = nums[k];
                                }
                                arr[i] = j;
                                arr[z] = p;
                                int numForAdd = 0;
                                numForAdd += arr[3];
                                numForAdd += arr[2] * 10;
                                numForAdd += arr[1] * 100;
                                numForAdd += arr[0] * 1000;
                                if (numForAdd != secretNumToTry)
                                {
                                    GuessNumbers.Add(numForAdd);
                                }
                            }

                        }
                    }
                }
            }


















            GuessNumbers.Sort();
            for (int i = 0
                ; i < GuessNumbers.Count
                ; i++)
            {
                if (GuessNumbers[i] != secretNumber)
                {
                    Console.Write(" {0}",
                        GuessNumbers[i]);
                }
            }
        }
    }
}

