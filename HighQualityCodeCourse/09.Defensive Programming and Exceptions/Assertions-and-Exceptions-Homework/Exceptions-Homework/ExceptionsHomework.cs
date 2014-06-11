using System;
using System.Collections.Generic;
using System.Text;

class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null)
        {
            throw new ArgumentNullException("array null parameter in Subsequence method");
        }
        if (arr.Length == 0)
        {
            throw new ArgumentException("Array is empty");
        }

        if (startIndex <= 0 || startIndex >= arr.Length || startIndex + count >= arr.Length || count < 1)
        {
            throw new ArgumentOutOfRangeException("Invalid indexer parameter startIndex:" + startIndex + " count:" + count);
        }
        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }
        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (str == null)
        {
            throw new ArgumentNullException("str parameter is null");
        }
        if (count > str.Length || count < 1)
        {
            throw new ArgumentOutOfRangeException("Invalid value of count parameter or out of range");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }
        return result.ToString();
    }

    public static bool CheckPrime(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("the method expect positiv integer");
        }
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        try
        {
            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));
        }
        catch (ArgumentNullException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (ArgumentOutOfRangeException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (ArithmeticException exception)
        {
            Console.WriteLine(exception.Message);
        }

        try
        {
            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));
            Console.WriteLine(ExtractEnding("Hi", 100));
        }
        catch (ArgumentNullException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (ArgumentOutOfRangeException excetion)
        {
            Console.WriteLine(excetion.Message);
        }


        try
        {
            if (CheckPrime(23))
            {
                Console.WriteLine("23 is prime.");
            }
            else
            {
                Console.WriteLine("23 is not prime.");
            }

            if (CheckPrime(33))
            {
                Console.WriteLine("33 is prime.");
            }
            else
            {
                Console.WriteLine("33 is not prime.");
            }

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
        catch(ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
