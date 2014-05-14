using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption_Handing
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    throw new ArgumentException("Invalid Number");
                }
                else
                {
                    Console.WriteLine(n * n);
                }
            }
            catch (Exception newExeption)
            {
                Console.WriteLine(newExeption.Message);
            }
            finally
            {
                Console.WriteLine("GoodBye");
            }
        }
    }
}
