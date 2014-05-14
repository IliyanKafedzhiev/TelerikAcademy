using System;
 class ReadTwoArrayComparator
{
    static void Main(string[] args)
    {
        int[] firstArray;
        int[] secondArray;
        Console.WriteLine("Input how many elements in arays");
        int elements = int.Parse(Console.ReadLine());
        firstArray = new int[elements];
        secondArray = new int[elements];
        for (int i = 0; i < elements; i++)
        {
            //Read from console
            Console.WriteLine("Input elements in first Array :{0}",i);
            firstArray[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Input elements in second Array :{0}", i);
            secondArray[i] = int.Parse(Console.ReadLine());

            //comapre 
            if (firstArray[i] > secondArray [i])
            {
                Console.WriteLine("Element in possition {0} is bigger in firstArray",i);
            }
            else if(secondArray [i] > firstArray[i])
            {
                Console.WriteLine("Element in possition {0} is bigger in secondArray", i);
            }
            else
            {
                Console.WriteLine("Elements in possition {0} are eqal",i);
            }

        }

    }
}

