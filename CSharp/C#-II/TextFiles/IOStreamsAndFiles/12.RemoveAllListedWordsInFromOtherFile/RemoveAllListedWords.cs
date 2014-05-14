using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RemoveAllListedWords

{
    class RemoveAllListedWords
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
            for (int i = startPosiotion; i < text.Length; i++)
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
                StreamReader inputStreamListedWord = new StreamReader("words.txt");
                List<string> listedWords = new List<string>();

                using (inputStreamListedWord)
                {
                    while (!inputStreamListedWord.EndOfStream)
                    {
                        listedWords.Add(inputStreamListedWord.ReadLine());
                    }
                }

                List<string> inputData = new List<string>();

                using (inputStream)
                {
                    while (!inputStream.EndOfStream)
                    {
                        string currentLine = new string(inputStream.ReadLine().ToCharArray());
                        for (int i = 0; i < listedWords.Count; i++)
                        {
                            currentLine = currentLine.Replace(listedWords[i], "");
                        }
                        inputData.Add(currentLine);

                    }


                }
                StreamWriter Writer = new StreamWriter("text1.txt");
                using (Writer)
                {
                    for (int i = 0; i < inputData.Count; i++)
                    {
                        Writer.WriteLine(inputData[i]);
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
