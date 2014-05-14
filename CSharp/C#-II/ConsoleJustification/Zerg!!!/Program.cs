using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Zerg___
{
    class Program
    {
        static string Return15Representation(string Code)
        {
            if (Code == "")
            {
                return "";
            }
            StringBuilder DecimalRepresentation = new StringBuilder();
            List<string> codeInSeparate = new List<string>();
            for (int i = 0; i < Code.Length; i+=4)
            {
                StringBuilder currLetter = new StringBuilder(4);
                for (int j = i; j < i+4; j++)
                {
                    currLetter.Append(Code[j]);
                }
                codeInSeparate.Add(currLetter.ToString());
            }
            for (int i = 0; i < codeInSeparate.Count; i++)
            {
                switch (codeInSeparate[i])
                {
                    case "Rawr":
                        DecimalRepresentation.Append(0);
                        break;
                    case "Rrrr":
                        DecimalRepresentation.Append(1);
                        break;
                    case "Hsst":
                        DecimalRepresentation.Append(2);
                        break;
                    case "Ssst":
                        DecimalRepresentation.Append(3);
                        break;
                    case "Grrr":
                        DecimalRepresentation.Append(4);
                        break;
                    case "Rarr":
                        DecimalRepresentation.Append(5);
                        break;
                    case "Mrrr":
                        DecimalRepresentation.Append(6);
                        break;
                    case "Psst":
                        DecimalRepresentation.Append(7);
                        break;
                    case "Uaah":
                        DecimalRepresentation.Append(8);
                        break;
                    case "Uaha":
                        DecimalRepresentation.Append(9);
                        break;
                    case "Zzzz":
                        DecimalRepresentation.Append('A');
                        break;
                    case "Bauu":
                        DecimalRepresentation.Append('B');
                        break;
                    case "Djav":
                        DecimalRepresentation.Append('C');
                        break;
                    case "Myau":
                        DecimalRepresentation.Append('D');
                        break;
                    case "Gruh":
                        DecimalRepresentation.Append('E');
                        break;

                    default:
                        break;
                }
            }
            char[] arr = DecimalRepresentation.ToString().ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
            //return DecimalRepresentation.ToString();
            
        }
        static int ReturnDecimalRepresentation(string Numbs)
        {
            int Code = 0;
            for (int i = 0; i < Numbs.Length; i++)
            {
                switch (Numbs[i])
                {
                    case '0':
                        Code += 0 * (int)Math.Pow(15, i);
                        break;
                    case '1':
                        Code += 1 * (int)Math.Pow(15, i);
                        break;
                    case '2':
                        Code += 2 * (int)Math.Pow(15, i);
                        break;
                    case '3':
                        Code += 3 * (int)Math.Pow(15, i);
                        break;
                    case '4':
                        Code += 4 * (int)Math.Pow(15, i);
                        break;
                    case '5':
                        Code += 5 * (int)Math.Pow(15, i);
                        break;
                    case '6':
                        Code += 6 * (int)Math.Pow(15, i);
                        break;
                    case '7':
                        Code += 7 * (int)Math.Pow(15, i);
                        break;
                    case '8':
                        Code += 8 * (int)Math.Pow(15, i);
                        break;
                    case '9':
                        Code += 9 * (int)Math.Pow(15, i);
                        break;
                    case 'A':
                        Code += 10 * (int)Math.Pow(15, i);
                        break;
                    case 'B':
                        Code += 11 * (int)Math.Pow(15, i);
                        break;
                    case 'C':
                        Code += 12 * (int)Math.Pow(15, i);
                        break;
                    case 'D':
                        Code += 13 * (int)Math.Pow(15, i);
                        break;
                    case 'E':
                        Code += 14 * (int)Math.Pow(15, i);
                        break;
                    default:
                        break;
                }
            }
            return Code;
        }
        static void Main(string[] args)
        {  
            try 
	        {
                Console.WriteLine(ReturnDecimalRepresentation(Return15Representation(Console.ReadLine())));
	        }
	        catch (Exception ex)
	        {
                Console.WriteLine(ex.Message);
		
	        }
        }
    }
}












