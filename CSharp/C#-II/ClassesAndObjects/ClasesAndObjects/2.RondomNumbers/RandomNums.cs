using System;

namespace IliyanClass
{
    class RandomNums
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(100,201));
            }
        }
    }
}

