//Write a program, that reads from the console an array of N integers and an integer K, sorts the array 
//and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 


using System;
using System.Collections.Generic;

class binerySearch_Matrix
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int K = int.Parse(Console.ReadLine());
        Array.Sort(array);

        int searchedInteger=-1 ;
        bool found = false;
        while (!found)
        {
            searchedInteger = Array.BinarySearch(array, K);
            if (searchedInteger > 0 )
            {
                found = true;
            }
            K--;
        }

        Console.WriteLine("Largest element <=K  :["+searchedInteger+"]" + array[searchedInteger]);
        
    }
}

