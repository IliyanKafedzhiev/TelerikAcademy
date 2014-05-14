//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).


using System;

class SortStringsByLenght
{
    static void sortByLenght (string[] array)
    {
        int i, j;
        for (i = 0; i < array.Length; i++)
        {
            for (j = 0; j < i; j++)
            {
                if (array[i].Length > array[j].Length)
                {
                    string temp = array[i]; //swap 
                    array[i] = array[j];
                    array[j] = temp;
                }

            }

        }

    }
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = Console.ReadLine();
        }
        sortByLenght(array);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

