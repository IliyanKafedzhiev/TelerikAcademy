//Extend the program to support also subtraction and multiplication of polynomials.
 

using System;


class Program
{
    static int[] AddsPolynomials(int[] first, int[] second)
    {
        int[] result = new int[Math.Max(first.Length, second.Length)];
        for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
        {
            result[i] = first[i] + second[i];
        }
        for (int i = Math.Min(first.Length, second.Length); i < Math.Max(first.Length, second.Length); i++)
        {
            result[i] = (second.Length > first.Length) ? second[i] : first[i];
        }
        return result;
    }
    static int[] SubstractingPolynomials(int[] first, int[] second)
    {
        int[] result = new int[Math.Max(first.Length, second.Length)];
        for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
        {
            result[i] = first[i] - second[i];
        }
        for (int i = Math.Min(first.Length, second.Length); i < Math.Max(first.Length, second.Length); i++)
        {
            result[i] = (second.Length > first.Length) ? second[i] : first[i];
        }
        return result;
    }
    static int[] MultiplicatePolynomialWhitInteger(int[] first, int integer)
    {
        int[] result = new int[first.Length];
        for (int i = 0; i < first.Length; i++)
        {
            result[i] = first[i] * integer;
        }
        return result;
    }
    static int[] AddZerosToPolynomial(int[] polynomial, int zeros)
    {
        int[] result = new int[polynomial.Length + zeros];
        int i = 0;
        for (i = 0 ; i < zeros; i++)
        {
            result[i] = 0;
        }
        for (int j = 0; j < polynomial.Length; j++)
        {
            result[i] = polynomial[j];
            i++;
        }
        return result;
    }
    static int[] MultiplicatePolynomials(int[] first, int[] second)
    {
        int[] result = new int[Math.Max(first.Length, second.Length)];
        for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
        {
            result = AddsPolynomials(result , MultiplicatePolynomialWhitInteger(AddZerosToPolynomial((first.Length > second.Length)?first:second,i) , (first.Length > second.Length)?second[i]:first[i]));
        }
        return result;
    }
    static void printPolinomial(int[] polynomial)
    {
        for (int i = polynomial.Length - 1; i > -1; i--)
        {
            if (i != 0)
            {
                Console.Write(polynomial[i] + "x^{0} + ", i);
            }
            else
            {
                Console.Write(polynomial[i] + "x^{0}", i);
            }
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        printPolinomial(MultiplicatePolynomials(new int[] { 3, 1 }, new int[] {  2 ,1 }));
    }
}

