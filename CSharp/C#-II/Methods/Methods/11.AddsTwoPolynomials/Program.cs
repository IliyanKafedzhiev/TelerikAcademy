//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		//x2 + 5 = 1x2 + 0x + 5 

using System;


class Program
{
    static int[] AddsPolynomials(int[] first, int[] second)
    {
        int[] result = new int[Math.Max(first.Length, second.Length)];
        for (int i = 0; i < Math.Min(first.Length,second.Length); i++)
        {
            result[i] = first[i] + second[i];
        }
        for (int i = Math.Min(first.Length,second.Length); i < Math.Max(first.Length,second.Length); i++)
        {
            result[i] = (second.Length > first.Length) ? second[i] : first[i];
        }
        return result;
    }
    static void printPolinomial(int[] polynomial )
    {
        for (int i = 0; i < polynomial.Length; i++)
		{
            if (i != polynomial.Length-1)
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
        printPolinomial(AddsPolynomials(new int[] { 2, 3, 4, 3, 2, 4, 3, 2 }, new int[] { 22, 23, 44 }));
    }
}

