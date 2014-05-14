using System;
using System.Collections.Generic;
using System.Text;

public static class Extensions
{
    public static StringBuilder Substring(this StringBuilder text, int index, int length)
    {
        if (index < 0 || index > text.Length || length < 0 || index + length > text.Length)
        {
            throw new IndexOutOfRangeException();
        }
        StringBuilder result = new StringBuilder(length);
        for (int i = index; i < index + length; i++)
        {
            result.Append(text[i]);
        }
        return result;
    }

}

class ExtensionMethods
{
    static void Main()
    {
        StringBuilder Ex = new StringBuilder("Here is some text for example");
        Console.WriteLine(Ex.Substring(5, 9).ToString()) ;
    }
}
