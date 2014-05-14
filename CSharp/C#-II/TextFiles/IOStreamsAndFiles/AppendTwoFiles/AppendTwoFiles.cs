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
                StreamWriter outputStream = new StreamWriter("output.txt");
                using(outputStream)
	            {
		            using (firstFile)
                    {
                        while (!firstFile.EndOfStream)
	                    {
	                        outputStream.WriteLine(firstFile.ReadLine());
	                    }
                    }

                    using (secondFile)
                    {
                        while (!secondFile.EndOfStream)
	                    {
	                        outputStream.WriteLine(secondFile.ReadLine());
	                    }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(IOException ex)
            {
               Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

	        
        }
    }
}
