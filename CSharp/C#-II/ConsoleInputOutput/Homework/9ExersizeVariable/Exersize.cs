using System;
class Exersize
{
    static void Main()
    {
        decimal first=0;
        decimal second=1;
        decimal nextNum=1;
        for (int i = 0; i < 100; i++)
        {
            nextNum = first;
            first = second;
            Console.WriteLine(second = second + nextNum); 

        }
    }
}
