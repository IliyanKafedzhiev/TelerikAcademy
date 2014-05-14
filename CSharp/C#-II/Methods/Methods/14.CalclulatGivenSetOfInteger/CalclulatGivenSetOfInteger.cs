//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.


using System;

class Program
{
    static int FindMinimum(int[] set)
    {
        int min = 25000000;
        for (int i = 0; i < set.Length; i++)
        {
            if (min > set[i])
            {
                min = set[i];
            }
        }
        return min;
    }
    static int FindMax(int[] set)
    {
        int max = -250000000;
        for (int i = 0; i < set.Length; i++)
        {
            if (max < set[i])
            {
                max = set[i];
            }
        }
        return max;
    }
    static int AvarageOfSequence(int [] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / array.Length;

    }
    static int SumOfSequence(int[] set)
    {
        int sum = 0;
        for (int i = 0; i < set.Length; i++)
		{
			 sum += set[i];
		}
        return sum;
    }
    static int ProductOfSequence(int[] set)
    {
        int product = 1;
        for (int i = 0; i < set.Length; i++)
        {
            product *= set[i];
        }
        return product;
    }
    static void Main(string[] args)
    {
        int large = int.Parse(Console.ReadLine());

        int[] set = new int[large];

        for (int i = 0; i < set.Length; i++)
        {
            set[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Minimum of sequence {0}",FindMinimum(set));
        Console.WriteLine("Maximum of sequence {0}", FindMax(set));
        Console.WriteLine("Avarage of sequence {0}", AvarageOfSequence(set));
        Console.WriteLine("Sum of sequence {0}", SumOfSequence(set));
        Console.WriteLine("Product of sequence {0}", ProductOfSequence(set));
        
       

    }
}

