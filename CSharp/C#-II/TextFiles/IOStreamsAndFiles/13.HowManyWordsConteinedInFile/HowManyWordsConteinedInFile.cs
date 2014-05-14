using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.HowManyWordsConteinedInFile
{
    class HowManyWordsConteinedInFile
    {
        struct WordsAndCounter
        {
            private string word;
            private int count;
            public string Word
            {
                get
                {
                    return word;
                }
                set
                {
                    word = value;
                }
            }
            public int Count
            {
                get
                {
                    return count;
                }
                set
                {
                    count = value;
                }
            }
        }
        static void Main(string[] args)
        {
            try
            {
                StreamReader inputStream = new StreamReader("text1.txt");
                StreamReader inputStreamListedWord = new StreamReader("words.txt");
                List<string> listedWords = new List<string>();
                List<int> WordsCounter = new List<int>();

                using (inputStreamListedWord)
                {
                    while (!inputStreamListedWord.EndOfStream)
                    {
                        listedWords.Add(inputStreamListedWord.ReadLine());
                        WordsCounter.Add(0);
                    }
                }

                List<string> inputData = new List<string>();

                using (inputStream)
                {
                    while (!inputStream.EndOfStream)
                    {
                        string currentLine = new string(inputStream.ReadLine().ToCharArray());
                        string [] words = currentLine.Split(' ');
                        for (int i = 0; i < words.Length; i++)
                        {
                            for (int j = 0; j < listedWords.Count; j++)
                            {
                                if (words[i] == listedWords[j])
                                {
                                    WordsCounter[j]++;
                                }
                            }
                        }
                    }
                }
                List<WordsAndCounter> ListWordsAndCounter = new List<WordsAndCounter>();
                for (int i = 0; i < listedWords.Count; i++)
                {
                    WordsAndCounter current = new WordsAndCounter();
                    current.Count = WordsCounter[i];
                    current.Word = listedWords[i];
                    ListWordsAndCounter.Add(current);
                }
                for (int i = 0; i < ListWordsAndCounter.Count; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (ListWordsAndCounter[i].Count > ListWordsAndCounter[j].Count)
                        {
                            WordsAndCounter temp = new WordsAndCounter(); //swap
                            temp = ListWordsAndCounter[i];
                            ListWordsAndCounter[i] = ListWordsAndCounter[j];
                            ListWordsAndCounter[j] = temp;
                        }
                    }
                }
                StreamWriter Writer = new StreamWriter("result.txt");
                using (Writer)
                {
                    for (int i = 0; i < ListWordsAndCounter.Count; i++)
                    {
                        Writer.WriteLine(ListWordsAndCounter[i].Word + " : " + ListWordsAndCounter[i].Count);
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
