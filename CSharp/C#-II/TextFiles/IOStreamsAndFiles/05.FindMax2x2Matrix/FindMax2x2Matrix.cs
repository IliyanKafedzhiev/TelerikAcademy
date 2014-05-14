using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AppendTwoFiles
{
    class AppendTwoFiles
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader firstFile = new StreamReader("text1.txt");
                StreamWriter outputStream = new StreamWriter("output.txt");
                using (firstFile)
                {
                    int maxSum = -100000000;
                    int ColRow = int.Parse(firstFile.ReadLine());
                    int[,] matrix = new int[ColRow, ColRow];
                    for (int i = 0; i < ColRow; i++)
                    {
                        string numbers = firstFile.ReadLine();
                        int cols = 0;
                        for (int j = 0; j < numbers.Length; j++)
                        {
                            if (numbers[j] != ' ')
	                        {
		                        matrix[i, cols] = int.Parse(numbers[j].ToString());
                                cols++;
	                        }  
                        }
                    }
                    for (int i = 0; i < ColRow - 1; i++)
                    {
                        for (int j = 0; j < ColRow - 1; j++)
                        {
                            int currentSum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
                            if (currentSum > maxSum)
                            {
                                maxSum = currentSum;
                            }
                        }
                    }


                    using (outputStream)
                    {
                        outputStream.WriteLine(maxSum);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
