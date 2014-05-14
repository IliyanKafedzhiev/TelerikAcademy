using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public static class IEnumExtensions
{
    public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
    {
        T min = collection.First();
        foreach (var element in collection)
        {
            if (element.CompareTo(min) < 0)
            {
                min = element;
            }
        }
        return min;
    }

    public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
    {
        T max = collection.First();
        foreach (var element in collection)
        {
            if (element.CompareTo(max) > 0)
            {
                max = element;
            }
        }
        return max;
    }

    public static decimal Product<T>(this IEnumerable<T> collection, Func<T, decimal> transformer = null)
    {
        if (transformer == null)
        {
            transformer = (x => Convert.ToDecimal(x));
        }
        decimal result = 1;
        try
        {
            foreach (var element in collection)
            {
                result *= transformer(element);
            }
        }
        catch (FormatException formEx)
        {
            throw new ArgumentException("Collection cannot be modifed with the default transformer!", formEx);
        }
        catch (InvalidCastException invEx)
        {
            throw new ArgumentException("Collection cannot be modifed with the default transformer!", invEx);
        }
        return result;
    }

    public static decimal Sum<T>(this IEnumerable<T> collection, Func<T, decimal> transformer = null)
    {
        if (transformer == null)
        {
            transformer = (x => Convert.ToDecimal(x));
        }
        decimal result = 0;
        try
        {
            foreach (var element in collection)
            {
                result += transformer(element);
            }
        }
        catch (FormatException formEx)
        {
            throw new ArgumentException("Collection cannot be modifed with the default transformer!", formEx);
        }
        catch (InvalidCastException invEx)
        {
            throw new ArgumentException("Collection cannot be modifed with the default transformer!", invEx);
        }
        return result;
    }

    public static decimal Average<T>(this IEnumerable<T> collection, Func<T, decimal> transformer = null)
    {
        decimal sum = collection.Sum(transformer);
        return sum / collection.Count();
    }

    public static void Print<T>(this IEnumerable<T> collection)
    {
        Console.Write("{ ");
        foreach (var element in collection)
        {
            Console.Write("{0} ", element);
        }
        Console.WriteLine("}");
    }


}

