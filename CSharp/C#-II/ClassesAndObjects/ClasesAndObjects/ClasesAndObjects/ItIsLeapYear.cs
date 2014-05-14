using System;

namespace IliyanClass
{
    class ItIsLeapYear
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Year is Leap");
            }
            else
            {
                Console.WriteLine("Year isn't Leap");
            }
        }
    }
}

