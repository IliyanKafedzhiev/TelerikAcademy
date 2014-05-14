using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace SortListOfStrings
{
    class SortListOfStrings
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader firstFile = new StreamReader("text1.txt");
                StreamWriter outputStream = new StreamWriter("textReplaced.txt");
                using (firstFile)
                {
                    using (outputStream)
                    {
                        while (!firstFile.EndOfStream)
                        {
                            string currentRow = firstFile.ReadLine();
                            string replaced = Regex.Replace(currentRow, @"\bstart\b", "finish") ;
                            outputStream.WriteLine(replaced);
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
            Console.WriteLine("Done!");

        }
    }
}

