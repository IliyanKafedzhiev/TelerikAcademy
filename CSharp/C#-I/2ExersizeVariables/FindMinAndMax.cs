using System;
class FindMinAndMax
{
    static void Main()
    {

        int x;
        Console.WriteLine("Input N");
        x = int.Parse(Console.ReadLine());
        if (x < 1)
        {
            Console.WriteLine("Erorr INPUT!");
        }
        int[] arr = new int[x];
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine(" Input num: ");
           arr[i]=int.Parse( Console.ReadLine());
        }
        int min = 900000;
        int max = -900000;
        for (int i = 0; i < x; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("Maximum is: {0}",max);
        Console.WriteLine("Minimum is: {0}",min);
    }
}
