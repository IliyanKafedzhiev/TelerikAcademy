using System;
class Exersize
{
    static void Main()
    {
        decimal radius;
        radius = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Perimetar is :{0}",((decimal)Math.PI)*radius*2);
    }
}
