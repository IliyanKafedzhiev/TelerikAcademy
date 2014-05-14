using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ML
{
    class Program
    {
        static int PositionOfLetter(string letter)
        {
            int res = 0;
            string let = letter.ToUpper();
            switch (let)
            {
                case "A":
                    res = 1;
                    break;
                case "B":
                    res = 2;
                    break;
                case "C":
                    res = 3;
                    break;
                case "D":
                    res = 4;
                    break;
                case "E":
                    res = 5;
                    break;
                case "F":
                    res = 6;
                    break;
                case "G":
                    res = 7;
                    break;
                case "H":
                    res = 8;
                    break;
                case "I":
                    res = 9;
                    break;
                case "J":
                    res = 10;
                    break;
                case "K":
                    res = 11;
                    break;
                case "L":
                    res = 12;
                    break;
                case "M":
                    res = 13;
                    break;
                case "N":
                    res = 14;
                    break;
                case "O":
                    res = 15;
                    break;
                case "P":
                    res = 16;
                    break;
                case "Q":
                    res = 17;
                    break;
                case "R":
                    res = 18;
                    break;
                case "S":
                    res = 19;
                    break;
                case "T":
                    res = 20;
                    break;
                case "U":
                    res = 21;
                    break;
                case "V":
                    res = 22;
                    break;
                case "W":
                    res = 23;
                    break;
                case "X":
                    res = 24;
                    break;
                case "Y":
                    res = 25;
                    break;
                case "Z":
                    res = 26;
                    break;

                default:
                    break;
            }
            return res;
        }
        static List<string> Input()
        {
            List<string> mainInput = new List<string>();
            string text = Console.ReadLine();
            string regex = @"\b(\w+)\b";
            MatchCollection matches = Regex.Matches(text, regex, RegexOptions.IgnoreCase);
            foreach (Match match in matches)
            {
                mainInput.Add(match.Value);
            }
            return mainInput;
        }
        static string Extract (List<string> words)
        {
            StringBuilder result = new StringBuilder();
            int move = 1;
            while(true)
            {
                StringBuilder currPart = new StringBuilder();
                
                for (int i = 0; i < words.Count; i++)
                {
                    if ((words[i].Length - move) > -1 )
                    {
                        currPart.Append(words[i][words[i].Length - move]);
                    }
                    
                }
                move++;
                if (currPart.Length == 0)
                {
                    break;
                }
                result.Append(currPart.ToString());
            }

            return result.ToString();
        }
        static string movingLetters(string input)
        {
            char[] inputArray = input.ToCharArray();
            for (int i = 0; i < inputArray.Length; i++)
            {
                string let = inputArray[i].ToString();
                int ahpPos = PositionOfLetter(let);
                int PositionToMove = (ahpPos + i) % inputArray.Length;
                if (PositionToMove>i)
                {
                    for (int j = i; j < PositionToMove; j++)
                    {
                        char current = inputArray[j];
                        inputArray[j] = inputArray[j + 1];
                        inputArray[j + 1] = current;
                    }
                }
                else if (PositionToMove < i)
                {
                    for (int j = i; j >PositionToMove ; j--)
                    {
                        char current = inputArray[j];
                        inputArray[j] = inputArray[j - 1];
                        inputArray[j - 1] = current;
                    }
                }
                
            }

            return new string(inputArray);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(movingLetters(Extract(Input())));
        }
    }
}
