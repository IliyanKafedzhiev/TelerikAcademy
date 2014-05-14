using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MinMax
{
    class MinMax
    {
        public static T Min<T>(T[] arr) where T : IComparable<T>
        {
            // Returns:
            //     A value that indicates the relative order of the objects being compared.
            //     The return value has the following meanings: Value Meaning Less than zero
            //     This object is less than the other parameter.Zero This object is equal to
            //     other. Greater than zero This object is greater than other.
            T min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(min) < 0)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static T Max<T>(T[] arr) where T : IComparable<T>
        {
            // Returns:
            //     A value that indicates the relative order of the objects being compared.
            //     The return value has the following meanings: Value Meaning Less than zero
            //     This object is less than the other parameter.Zero This object is equal to
            //     other. Greater than zero This object is greater than other.
            T max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(max) > 0)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 43, 3, 2, 4, 5, 43, 2, 3 };
            Console.WriteLine(Min<int>(arr));
            Console.WriteLine(Max<int>(arr));
            
          
            Console.WriteLine();
        }
    }
}
