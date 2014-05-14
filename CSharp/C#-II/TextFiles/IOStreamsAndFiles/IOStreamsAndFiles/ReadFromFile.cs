using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOStreamsAndFiles
{
    class ReadFromFile
    {
        static void Main(string[] args)
        {
            StreamReader textFile = new StreamReader("text.txt",Encoding.GetEncoding("windows-1251"));
            try
            {
                int i = 1;
                while (!textFile.EndOfStream)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(textFile.ReadLine());
                    }
                    else
                    {
                        textFile.ReadLine();
                    }
                    i++;
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
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                textFile.Close();
            }
        }
    }
}
