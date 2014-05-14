using System;

class CalculateWorkDaysUpToDate
{
    static DateTime [] nationalHolidays = new DateTime[5]; // Inicializated Holiday's day's

    static int CalculateWorkDaysUpToDateMethod(DateTime upToDate)
    {
        int workDays = 0;
        DateTime currentDate = DateTime.Today;
        while (true)
        {
            if (!(currentDate.DayOfWeek == DayOfWeek.Sunday) && !(currentDate.DayOfWeek == DayOfWeek.Saturday) && !(currentDate.Day == nationalHolidays[0].Day)
                && !(currentDate.Day == nationalHolidays[1].Day) && !(currentDate.Day == nationalHolidays[2].Day) && !(currentDate.Day == nationalHolidays[3].Day)
                && !(currentDate.Day == nationalHolidays[4].Day) )
            {
                Console.WriteLine(currentDate.ToString());
                workDays++;
            }
            if (currentDate.Day == upToDate.Day && currentDate.Month == upToDate.Month)
            {
                break;
            }
            currentDate = currentDate.AddDays(1);
        }
        return workDays;
    }
    static void Main(string[] args)
    {
        DateTime myHoliday = new DateTime(2013, 10, 28);
        Console.WriteLine(CalculateWorkDaysUpToDateMethod(myHoliday));
    }
}

