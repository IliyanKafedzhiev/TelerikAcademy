using System;
class Exersize
{
    static void Main()
    {
        int firstCheckInteger;
        Console.WriteLine("Input first number");
        firstCheckInteger = int.Parse(Console.ReadLine());
        int secondCheckInteger;
        Console.WriteLine("Input second number");
        secondCheckInteger = int.Parse(Console.ReadLine());
        Console.WriteLine("Greater NUM is:{0}",(firstCheckInteger>secondCheckInteger)?firstCheckInteger:secondCheckInteger);
    }
}
