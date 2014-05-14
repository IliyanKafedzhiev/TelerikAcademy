using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace SortListOfStrings
{
    class SortListOfStrings
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader firstFile = new StreamReader("text1.txt");
                StreamWriter outputStream = new StreamWriter("output.txt");
                using (firstFile)
                {
                    List<string> contain = new List<string>();
                    while (!firstFile.EndOfStream)
                    {
                        contain.Add(firstFile.ReadLine());
                    }
                    contain.Sort();
                    using (outputStream)
                    {
                        for (int i = 0; i < contain.Count; i++)
                        {
                            outputStream.WriteLine(contain[i]);
                        }
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
            finally
            {
                Console.WriteLine("Done!");
            }


        }
    }
}

