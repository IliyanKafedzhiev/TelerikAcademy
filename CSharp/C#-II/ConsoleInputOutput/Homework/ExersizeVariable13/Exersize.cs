using System;
class Exersize
{
    static void Main()
    {
        //Console.BackgroundColor = (ConsoleColor)(10);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy");
        
        ConsoleKeyInfo CurrentKey = Console.ReadKey();
        
        if (CurrentKey.Key == ConsoleKey.A)
        {
            Console.WriteLine("Sucsess");
        }
    }
}
