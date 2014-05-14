using System;

class AddsTwoPossitiveIntegerNumberPresenterByArray
{
    static byte[] Add (byte[] first, byte[] second)
    {
        byte[] result = new byte[Math.Max(first.Length, second.Length) + 1];
        int i = 0;
        int rest = 0;

        for (;i < Math.Min(first.Length,second.Length); i++)
        {
            result[i] = (byte)(first[i] + second[i] + rest);

            rest = result[i] / 10;

            result[i] %= 10;
        }
        if (first.Length > second.Length)
	    {
            for (; i < first.Length && rest != 0; i++)
            {
                result[i] = (byte)(first[i] + rest);

                rest = result[i] / 10;
                result[i] %= 10;
            }
            for (; i < first.Length; i++)
            {
                result[i] = first[i];
            }
	    }
        else
        {
            for (; i < second.Length && rest != 0; i++)
            {
                result[i] = (byte)(second[i] + rest);

                rest = result[i] / 10;
                result[i] %= 10;
            }
            for (; i < second.Length; i++)
            {
                result[i] = second[i];
            }
        }

        if (rest != 0) result[i] = 1;
        else Array.Resize(ref result, result.Length - 1);


        return result;
    }
    static void Main(string[] args)
    {
       
        byte [] result = Add(new byte[] { 1 }, new byte[] { 9, 9, 9 });
        for (int i  = result.Length-1; i  > -1; i --)
        {
            Console.Write(result[i]);
        }
    }
}

