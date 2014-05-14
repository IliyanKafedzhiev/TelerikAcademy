using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();
            StringBuilder result = new StringBuilder(Input.Length);
            for (int i = Input.Length-1; i > -1; i--)
            {
                result.Append(Input[i]);
            }
            Console.WriteLine(result.ToString());
        }
    }
}
