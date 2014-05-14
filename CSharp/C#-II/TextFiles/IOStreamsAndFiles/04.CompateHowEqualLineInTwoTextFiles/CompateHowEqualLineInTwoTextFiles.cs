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
                StreamReader secondFile = new StreamReader("text2.txt");
                using (firstFile)
                {

                    using (secondFile)
                    {
                        int equalLine = 0;
                        int unEqualLine = 0;
                        while (!secondFile.EndOfStream)
                        {
                            if (firstFile.ReadLine() == secondFile.ReadLine())
                            {
                                equalLine++;
                            }
                            else
                            {
                                unEqualLine++;
                            }
                        }
                        Console.WriteLine("There are {0} equal lines and {1} different LInes",equalLine,unEqualLine);
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
