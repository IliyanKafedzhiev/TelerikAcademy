using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExtractXMLWithoutTheTags
{
    class ExtractXMLWithoutTheTags
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader inputStream = new StreamReader("text1.txt");
                List<char> inputData = new List<char>();
                using (inputStream)
                {
                    while (!inputStream.EndOfStream)
                    {
                        string currentLine;
                        currentLine = inputStream.ReadLine();
                        bool isInTag = false;
                        for (int i = 0; i < currentLine.Length; i++)
                        {
                            if (currentLine[i] == '<')
                            {
                                isInTag = true;
                            }
                            else if (currentLine[i] == '>')
                            {
                                isInTag = false;
                            }
                            if (!isInTag && currentLine[i] != '>')
                            {
                                inputData.Add(currentLine[i]);
                            }
                        }
                        inputData.Add('\n');
                    }
                    
                    
                }
                StreamWriter Writer = new StreamWriter("text1.txt");
                using (Writer)
                {
                    for (int i = 0; i < inputData.Count; i++)
                    {
                        Writer.Write(inputData[i]);
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
