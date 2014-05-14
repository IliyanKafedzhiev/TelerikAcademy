using System;
class Exersize
{
    static void Main()
    {
        int countNumber;
        Console.WriteLine("Input how many numbers:");
        countNumber = int.Parse(Console.ReadLine());
        int sum=0;
        for (int i = 0; i < countNumber; i++)
        {
            Console.WriteLine("Input {0} number",i+1);
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine("They're sum is {0}",sum);
    }
}
