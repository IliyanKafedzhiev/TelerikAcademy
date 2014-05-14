using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeleteEveryOddLine
{
    class DeleteEveryOddLine
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader inputStream = new StreamReader("text1.txt");
                List<string> inputData= new List<string>();
                using (inputStream)
                {
                    int count = 1;
                    while (!inputStream.EndOfStream)
                    {
                        if (count % 2 == 1)
                        {
                             inputData.Add(inputStream.ReadLine());
                        }
                        else
                        {
                            inputStream.ReadLine();
                        }
                        count++;
                    }
                }
                StreamWriter outputStream = new StreamWriter("text1.txt", false);
                using (outputStream)
                {
                    for (int i = 0; i < inputData.Count; i++)
                    {
                        outputStream.WriteLine(inputData[i]);
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
