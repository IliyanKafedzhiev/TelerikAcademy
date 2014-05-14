//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).


using System;



class IsBiggerByNeighborElements
{
    static bool IsBigger (int[] array, int position)
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
            else if ((position + 1) < array.Length && (position-1) >= 0 
                && array[position] > array[position + 1] && array[position] > array[position - 1])
            {
                return true;
            }
        }
        return false;
    }
    static void Main(string[] args)
    {
        int[] array = new int[] { 2, 4, 5, 2, 2, 3, 2 };

        Console.WriteLine(IsBigger(array, 3));

    }
}

