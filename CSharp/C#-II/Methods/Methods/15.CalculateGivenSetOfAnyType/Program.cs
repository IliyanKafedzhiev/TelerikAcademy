//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).


using System;
using System.Collections.Generic;


class Program
{
    static T FindMinimum <T>(T[] set)
    {
        dynamic min = set [0];
        for (int i = 0; i < set.Length; i++)
        {
            if (min > set[i])
            {
                min = set[i];
            }
        }
        return min;
    }
    static T FindMax<T>(T[] set)
    {
        dynamic max = set[0];
        for (int i = 0; i < set.Length; i++)
        {
            if (max < set[i])
            {
                max = set[i];
            }
        }
        return max;
    }
    static T AvarageOfSequence<T>(T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / array.Length;

    }
    static T SumOfSequence<T>(T[] set)
    {
        dynamic sum = 0;
        for (int i = 0; i < set.Length; i++)
        {
            sum += set[i];
        }
        return sum;
    }
    static T ProductOfSequence <T>(T[] set)
    {
        dynamic product = 1;
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

        Console.WriteLine("Minimum of sequence {0}", FindMinimum<int>(set));
        Console.WriteLine("Maximum of sequence {0}", FindMax(set));
        Console.WriteLine("Avarage of sequence {0}", AvarageOfSequence(set));
        Console.WriteLine("Sum of sequence {0}", SumOfSequence(set));
        Console.WriteLine("Product of sequence {0}", ProductOfSequence(set));



    }
}


