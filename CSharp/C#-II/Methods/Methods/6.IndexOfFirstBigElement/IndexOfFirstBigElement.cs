//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise

using System;

class IndexOfFirstBigElement
{
    static bool IsBigger(int[] array, int position)
    {
        if (position < array.Length && position >= 0)
        {
            if (position == 0 && array[position] > array[position + 1])
            {
                return true;
            }
            else if (position == (array.Length - 1) && array[position] > array[position - 1])
            {
                return true;
            }
            else if ((position + 1) < array.Length && (position - 1) >= 0
                && array[position] > array[position + 1] && array[position] > array[position - 1])
            {
                return true;
            }
        }
        return false;
    }
    static int PositionOfFirstBigElement(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (IsBigger(array,i))
            {
                return i;
            }
        }
        return -1;
    }
    static void Main(string[] args)
    {
        int[] array = new int[] { 2, 4, 4, 2, 2, 3, 2 };

        Console.WriteLine(PositionOfFirstBigElement(array));

    }
}

