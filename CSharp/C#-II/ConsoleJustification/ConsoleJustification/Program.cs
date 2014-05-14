using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class JorosProblem
{
    static void printLine(ref List<string>CurrentLine,int  numOfWordsinLine)
    {
        int counter = numOfWordsinLine + (numOfWordsinLine - 1);
        for (int i = 0; i < counter; i++)
		{
		   Console.Write(CurrentLine[i]);
		}
        Console.WriteLine();
    }
    static void removeAllElements(ref List<string>CurrentLine)
    {
        CurrentLine.Clear();
    }
    static void setGaps(ref List<string>CurrentLine, int neededGaps,int numOfWordsinLine)
    {
        int numberOfObjects = numOfWordsinLine + (numOfWordsinLine - 1);
        for (int i = 0; i < neededGaps; i++)
        {
            for (int j = 1; (j < numberOfObjects) && (i < neededGaps); j += 2)
            {
                CurrentLine[j] = CurrentLine[j] + " ";
                i++;
            }
        }
    }
    static void Run ()
    {
        int lines = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        List<string> mainInput= new List<string>();
        Regex reg = new Regex(@"\b(\w+)\b");
        for (int i = 0; i < lines; i++)
        {
            string text = Console.ReadLine();
            string regex = @"\b(\w+)\b";
            MatchCollection matches = Regex.Matches(text,regex,RegexOptions.IgnoreCase);
            foreach (Match match in matches)
	        {
                mainInput.Add(match.Value);
	        }
            
        }
        int numOfWordsinLine=0;
        int currentCharactersInLine = 0;
        List<string> CurrentLine = new List<string>();
        for (int i = 0; i < mainInput.Count; i++)
        {
            if (mainInput[i].Length > width)
            {
                throw new Exception("Error thare are word too longer");
            }
            CurrentLine.Add(mainInput[i]);
            numOfWordsinLine++;
            currentCharactersInLine += mainInput[i].Length;
                
            if (currentCharactersInLine == width)
            {
                break;
                printLine(ref CurrentLine, numOfWordsinLine);
                numOfWordsinLine = 0;
                currentCharactersInLine = 0;
                removeAllElements(ref CurrentLine);
                
            }
            if (currentCharactersInLine > width)
            {
                currentCharactersInLine= currentCharactersInLine - mainInput[i].Length;
                i--;
                numOfWordsinLine--;
                int neededGaps = width - currentCharactersInLine;
                setGaps(ref CurrentLine, neededGaps, numOfWordsinLine);
                printLine(ref CurrentLine, numOfWordsinLine);
                numOfWordsinLine = 0;
                currentCharactersInLine = 0;
                removeAllElements(ref CurrentLine);
            }
            if (currentCharactersInLine != width)
            {
                CurrentLine.Add(" ");
                currentCharactersInLine++;
            }       
            if ((i+1)==mainInput.Count)
            {
                printLine(ref CurrentLine, numOfWordsinLine);
            }
        }
     }
    static void Main(string[] args)
    {
        try
        {
            Run();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
        
    }
}

