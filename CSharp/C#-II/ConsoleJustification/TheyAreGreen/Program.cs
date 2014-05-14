using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TheyAreGreen
{
    class Program
    {
        static BigInteger Factorial(int n)
        {
            BigInteger fact=1;
            for (int i = 1; i < n+1; i++)
            {
                fact *= i;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            
            int N = int.Parse(Console.ReadLine());
            List<char> chars = new List<char>();
            for (int i = 0; i < N; i++)
            {
                chars.Add(char.Parse(Console.ReadLine()));
            }
            
            List<char> charsWithoutReps = new List<char>();
            for (int i = 0; i < N; i++)
            {
                if (!charsWithoutReps.Contains(chars[i]))
                {
                    charsWithoutReps.Add(chars[i]);
                }
            }

            int[] counterForEachLetter = new int[charsWithoutReps.Count];
            for (int i = 0; i < charsWithoutReps.Count; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (charsWithoutReps[i] == chars[j])
                    {
                        counterForEachLetter[i]++;
                    }
                }
            }
            int wodrsWithConcatChar = 0;
            for (int i = 0; i < counterForEachLetter.Length; i++)
            {
                if (counterForEachLetter[i] > 1)
                {
                    wodrsWithConcatChar += counterForEachLetter[i];
                }
                
            }
            Console.WriteLine((Factorial(N)-Factorial(N-wodrsWithConcatChar)));
        }
    }
}
