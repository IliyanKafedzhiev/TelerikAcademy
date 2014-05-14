using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ValidateExpression
{
    class ValidateExpression
    {
        static bool ValidateExpression(string input)
        {
            int openBrackets = 0;
            int closedBrackets = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openBrackets++;
                }
                else if (input[i] == ')')
                {
                    if (closedBrackets >= openBrackets)
                    {
                        return false;
                    }
                    closedBrackets++;
                }
            }
            if (openBrackets != closedBrackets)
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            if (ValidateExpression(Console.ReadLine()))
	        {
                Console.WriteLine("Ok");
	        }
            else
            {
                Console.WriteLine("Nope");
            }
            
        }
    }
}
