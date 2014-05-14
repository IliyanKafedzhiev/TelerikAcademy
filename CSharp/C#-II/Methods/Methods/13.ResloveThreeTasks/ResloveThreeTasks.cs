//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//        Create appropriate methods.
//        Provide a simple text-based menu for the user to choose which task to solve.
//        Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0


using System;

class ResloveThreeTasks
{
    
    static void ReverseDigit(ref int digit)
    {
        string digitString = digit.ToString();
        char[] arrayOfChar = new char[digitString.Length];
        for (int i = 0; i < digitString.Length ; i++)
        {
            arrayOfChar [i] = digitString[i];  
        }
        for (int i = 0; i < digitString.Length/2; i++)
        {
            char a = arrayOfChar[i];
            arrayOfChar[i] = arrayOfChar[digitString.Length - 1 - i];
            arrayOfChar[digitString.Length - 1 - i] = a;
        }
        string lastStrig = new string(arrayOfChar); 
        digit = int.Parse(lastStrig);
    }
    static void ChosenReverse()
    {
        Console.WriteLine("Please Write down the number , who you want to reverse:");
        int digitToReverse = int.Parse(Console.ReadLine());
        if (digitToReverse < 0)
        {
            Console.WriteLine("The number must be non negative");
            return;
        }
        ReverseDigit(ref digitToReverse);
        Console.WriteLine("Result : {0}",digitToReverse);
    }
    static void AvarageOfSequence()
    {
        Console.WriteLine("Please Input how many nums you have:");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("The count of sequence must be > 0");
            return;
        }
        int[] array = new int[n];
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Please input a num:");
            array[i] = int.Parse(Console.ReadLine());
            sum += array[i];
        }
        Console.WriteLine("The avarage of sequence is {0}", sum / n);

    }
    static void LinearEquation()
    {
        Console.WriteLine("Please input data first coef a:");
        double a = double.Parse(Console.ReadLine());
        if (a == 0 )
        {
            Console.WriteLine("First coef must be Defferent by zero");
            return;
        }
        Console.WriteLine("Please Input second coef b:");
        double b = double.Parse(Console.ReadLine());
        if (b == 0 )
        {
            Console.WriteLine("The slove of equation is \"0\"");
        }
        else
        {
            Console.WriteLine("The slove of equation is:{0}",(-b)/a);
        }

    }
    static void Main(string[] args)
    {
        byte choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("Choice what to do : ");
            Console.WriteLine("For reverse some digit please press 1");
            Console.WriteLine("For Calculates the average of a sequence of integers please press 2");
            Console.WriteLine("For Solves a linear equation a * x + b = 0 please press 3");
            Console.WriteLine("For exit  please press 4");
            choice = byte.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ChosenReverse();
                    break;
                case 2:
                    AvarageOfSequence();
                    break;
                case 3:
                    LinearEquation();
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }
    }
    
}

