using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodingDecoding
{
    class EncodingAndDecoding
    {
        static string Encrypt(string message, string cypher)
        {
            StringBuilder Encrypt = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                if (message.Length >= cypher.Length)
                {
                    int res =  ((int)message[i]-65) ^ ((int)cypher[i % cypher.Length]-65);
                    char newChar = (char)(res + 65);
                    Encrypt.Append(newChar);
                }
                else
                {
                    int j = i + message.Length;
                    int res = ((int)message[i] - 65) ^ ((int)cypher[i % cypher.Length] - 65);
                    char newChar = (char)(res + 65);
                    while (j < cypher.Length)
                    {
                        res = ((int)newChar - 65) ^ ((int)cypher[j] - 65);
                        newChar = (char)(res + 65);
                        j += message.Length;
                        
                    }
                    Encrypt.Append(newChar);
                }
                
            }
            return Encrypt.ToString();
        }
        static string ReplaceMod(string partForReplacing, int from, int to,string text)
        {
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < from; i++)
            {
                res.Append(text[i]);
            }
            for (int i = 0; i < 2; i++)
            {
                res.Append(partForReplacing[i]);
            }
            for (int i = to; i < text.Length; i++)
            {
                res.Append(text[i]);
            }
            return res.ToString();
        }
        static string Encode(string text)
        {
            //StringBuilder toCompress = new StringBuilder();
            string partForReplacing;
            for (int i = 0; i < text.Length; i++)
            {
                int counter = 0;
                for (int k = i; k < text.Length; k++)
                {
                    if (text[i] == text[k])
                    {
                        counter++;
                    }
                    else if (counter > 2)
                    {
                        partForReplacing = counter.ToString() + text[i];
                        text = ReplaceMod(partForReplacing, i, i + counter, text);
                        break;
                    }
                    else
	                {
                        break;
	                }
                }
            }
            return text;
        }
        static void Main(string[] args)
        {
            
            try
            {
                string message = Console.ReadLine();
                string cypher = Console.ReadLine();
                //Console.WriteLine(Encrypt("ABC","PQRST"));
                Console.WriteLine(Encode(Encrypt(message, cypher) + cypher) + cypher.Length.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
