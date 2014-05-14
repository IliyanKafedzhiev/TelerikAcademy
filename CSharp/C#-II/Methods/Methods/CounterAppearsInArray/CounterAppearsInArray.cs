//Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.


using System;

class CounterAppearsInArray
{
    static int CounterApparesInArray (int[] arr, int element)
    {
       int counter = 0;
        for (int i = 0; i < arr.Length; i++)
		{
		    if (arr[i] == element)
	        {
		        counter++;
	        }
		}

        return counter;

    }
    static void Main(string[] args)
    {
        int[] array = new int[] { 2, 4, 5, 2, 2, 3, 2 };

        Console.WriteLine(CounterApparesInArray(array,2));

    }
}

