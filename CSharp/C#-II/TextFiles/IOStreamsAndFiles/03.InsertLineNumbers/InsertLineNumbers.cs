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
                using (outputStream)
                {
                    int count = 1;
                    using (firstFile)
                    {
                        while (!firstFile.EndOfStream)
                        {
                            outputStream.WriteLine(count++ + ":" + firstFile.ReadLine());
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
           
        }
    }
}
