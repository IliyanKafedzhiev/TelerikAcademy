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
        static bool HasPrefixTest(int startPosition, string text)
        {
            if (startPosition == 0 || text[startPosition - 1] == ' ')
            {
                if (text[startPosition++] == 't' && startPosition + 4 < text.Length - 1)
                {
                    if (text[startPosition++] == 'e')
                    {
                        if (text[startPosition++] == 's')
                        {
                            if (text[startPosition] == 't')
                            {
                                return true;
                            }
                        }
                    }
                }
            }
                
            return false;
        }
        static int HowMuchSymbolsHasAfterPrefix(int startPosiotion, string text)
        {
            startPosiotion += 4; // escape prefix
            int countIndex = 0;
            for (int  i= startPosiotion; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    countIndex++;
                }
                else
                {
                    break;
                }
            }
            return countIndex;
        }
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
                        for (int i = 0; i < currentLine.Length; i++)
                        {
                            if (HasPrefixTest(i,currentLine))
                            {
                                i += HowMuchSymbolsHasAfterPrefix(i, currentLine);
                                i += 4;
                            }
                            if (i < currentLine.Length)
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
