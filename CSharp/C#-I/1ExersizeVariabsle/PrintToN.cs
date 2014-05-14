using System;
class PrintToN
{
    static void Main()
    {

        int x;
        Console.WriteLine("Input N");
        x = int.Parse(Console.ReadLine());
        if (x<1)
        {
            Console.WriteLine("Erorr INPUT!");
        }
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine(" {0} ",i);
        }
    }
}
