using System;
class Exersize
{
    static void Main()
    {
        decimal sum = 1;
        decimal tmpSum;
        const decimal accuracy =(decimal) 0.001;
        decimal  i = 2;
        do
        {
            tmpSum = sum;
            if (i % 2 == 1)
            {
                sum = sum - (1 / i);
            }
            else
            {
                sum = sum + (1 / i);
            }
            i++;
        }
        while ((decimal)(Math.Abs(sum - tmpSum)) > accuracy);
        Console.WriteLine("Sum is :{0}", sum);

    }
}
