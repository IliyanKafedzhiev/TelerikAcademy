using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SubstringCounter
{
    class SubstringCounter
    {
        static int substringCounter(string input, string substring)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i+substring.Length >= input.Length)
                {
                    break;
                }
                StringBuilder currentSubstr = new StringBuilder(substring.Length);
                for (int j = i; j < i + substring.Length; j++)
                {
                    currentSubstr.Append(input[j]);
                }
                if (substring.ToUpper() == currentSubstr.ToString().ToUpper())
                {
                    count++;
                }
            }
            return count;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(substringCounter(Console.ReadLine(),Console.ReadLine()));
        }
    }
}
