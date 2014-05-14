using System;

namespace IliyanClass
{
    class WhichDayIsToday
    {
        
        static void Main(string[] args)
        {
            DateTime curentDate;
            curentDate = DateTime.Today;
            Console.WriteLine(curentDate.DayOfWeek);
        }
    }
}

