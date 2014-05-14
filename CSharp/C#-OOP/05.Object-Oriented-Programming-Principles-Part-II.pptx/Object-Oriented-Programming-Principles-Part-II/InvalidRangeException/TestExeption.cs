using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidRangeException
{
    class Program
    {
        static public void ThrowExceptionInt()
        {
            throw new InvalidRangeException<int>(1,100,"Range for this method crossed ! ");
        }
        static public void ThrowExceptionDateTime()
        {
            throw new InvalidRangeException<DateTime>(new DateTime(1980, 1, 1), new DateTime(2013, 12, 31), "Current Date is unreal Please check Date!");
        }
        static void Main(string[] args)
        {
            try
            {
                ThrowExceptionDateTime();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                try
                {
                    ThrowExceptionInt();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
