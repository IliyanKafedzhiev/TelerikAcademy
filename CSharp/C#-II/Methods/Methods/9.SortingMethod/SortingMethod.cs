//Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.


using System;

class SortingMethod
{
    static int MaxElementInPartitionArray(int[] array, int positionFrom)
    {
        int maxElement = positionFrom;
        for (int i = positionFrom; i < array.Length; i++)
        {
            if (array[i] > array[maxElement])
            {
                maxElement = i;
            }
        }
        return maxElement;
    }
    static int[] SortingArrayDescendingOrther(int[] array)
    {
        int maxElement = 0;
        for (int i = 0; i < array.Length; i++)
        {
            maxElement = MaxElementInPartitionArray(array, i);
            int carry = array[i];
            array[i] = array [maxElement];
            array[maxElement] = carry;
        }
        return array;
    }
    static int[] SortingArrayAscendingOrther(int[] array)
    {
        SortingArrayDescendingOrther(array);
        for (int i = 0; i < array.Length / 2; i++)
        {
            int swap = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = swap;
        }
        return array;
    }
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    static void Main(string[] args)
    {
        int[] array = new int[] { 1, 3, 52, 3, 2, 23, 54, 3, 2, 4, 3243, 2, };
        PrintArray(SortingArrayAscendingOrther(array));
        

    } 
}

