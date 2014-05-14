using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class CalculateExpression
{
    static List<char> AritmeticOperation = new List<char> { '*', '/', '+', '-' };

    static List<char> Brackets = new List<char> { '(', ')' };

    static List<string> Functions = new List<string> {"pow","sqrt","ln"}; 

    static string TrimStringFromSpace(string intput)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < intput.Length; i++)
        {
            if (intput[i] != ' ')
            {
                result.Append(intput[i]);
            }
        }
        return result.ToString();
    }

    static List<string> SaparateOperationsAndNums(string expression)
    {
        var OperationsAndNums = new List<string>();
        StringBuilder currentNum = new StringBuilder();
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '-' && (i == 0 || expression[i-1] == ',' || expression[i-1] == '('))
            {
                currentNum.Append('-');
            }
            else if (char.IsDigit(expression[i]) || expression[i] == '.')
            {
                currentNum.Append(expression[i]);
            }
            else if (!char.IsDigit(expression[i]) && currentNum.Length > 0 && expression[i] != '.')
	        {
                OperationsAndNums.Add(currentNum.ToString());
                currentNum.Clear();
                i--;
	        }
            else   if (Brackets.Contains(expression[i]))
            {
                OperationsAndNums.Add(expression[i].ToString());
            }
            else if (AritmeticOperation.Contains(expression[i]))
            {
                OperationsAndNums.Add(expression[i].ToString());
            }
            else if (expression[i] == ',')
            {
                OperationsAndNums.Add(",");
            }
            else if ( i + 1 < expression.Length && expression.Substring(i,2).ToLower() == "ln")
            {
                OperationsAndNums.Add("ln");
                i++;
            }
            else if (i+2 < expression.Length && expression.Substring(i,3).ToLower() == "pow")
            {
                OperationsAndNums.Add("pow");
                i += 2 ;
            }
            else if ( i+3 <expression.Length && expression.Substring (i,4).ToLower() == "sqrt")
            {
                OperationsAndNums.Add("sqrt");
                i += 3;
            }
            else
            {
                throw new ArgumentException("Invalid Expression");
            }
            
        }
        if (currentNum.Length != 0)
        {
            OperationsAndNums.Add(currentNum.ToString());
        }
        return OperationsAndNums;
    }

    static void PutInvariantCulture()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
    }

    static int PRecedence(string aritmeticOperator)
    {
        if (aritmeticOperator == "+" || aritmeticOperator == "-")
        {
            return 2;
        }
        return 1;
    }

    static Queue<string> ConvertToReversePolishNotation(List<string> tokens)
    {
        Queue<string> queue = new Queue<string>();
        Stack<string> stack = new Stack<string>();
        for (int i = 0; i < tokens.Count; i++)
        {
            var curToken = tokens[i];
            double number;
            if (double.TryParse(curToken,out number))
            {
                queue.Enqueue(curToken);
            }
            else if (Functions.Contains(curToken))
            {
                stack.Push(curToken);
            }
            else if (curToken == ",")
            {
                if (!stack.Contains("(") || stack.Count == 0)
                {
                    throw new ArgumentException("Invalid Expression");
                }
                // if not working => put "("
                while (stack.Peek() != "(")
                {
                    queue.Enqueue(stack.Pop());
                }
            }
            else if (AritmeticOperation.Contains(curToken[0]))
	        {
		            // if not work...
                while ( stack.Count != 0 && AritmeticOperation.Contains(stack.Peek()[0]) && PRecedence(curToken) <= PRecedence(stack.Peek()))
                {
                    queue.Enqueue(stack.Pop());
                }
                stack.Push(curToken);
	        }
            else if (curToken == "(")
            {
                stack.Push("(");
            }
            else if (curToken == ")")
            {
                if (!stack.Contains("(") || stack.Count == 0)
                {
                    throw new ArgumentException("Invalid brackets position");
                }
                while (stack.Pop() != "(")
                {
                    queue.Enqueue(stack.Pop());
                }

                stack.Pop();
                if (stack.Count != 0 &&  Functions.Contains(stack.Peek()))
                {
                    queue.Enqueue(stack.Peek());
                }
            }
        }
        while (stack.Count != 0)
        {
            if (Brackets.Contains(stack.Peek()[0]))
            {
                throw new ArgumentException("Invalid Brakets exeption");
            }
            queue.Enqueue(stack.Pop());
        }
        return queue;
    }

    static double GetResultFromRPN(Queue<string> intput)
    {
        Stack<double> stack = new Stack<double>();
        double number;
        while (intput.Count != 0)
        {
            string currentToken = intput.Dequeue();
            if (double.TryParse(currentToken, out number))
            {
                stack.Push(number);
            }
            else if (AritmeticOperation.Contains(currentToken[0]) || Functions.Contains(currentToken))
            {
                if (currentToken == "+")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArithmeticException("Invalid expression");
                    }
                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(secondValue + firstValue);
                }
                if (currentToken == "-")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArithmeticException("Invalid expression");
                    }
                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(secondValue - firstValue);
                }
                if (currentToken == "*")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArithmeticException("Invalid expression");
                    }
                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(secondValue * firstValue);
                }
                if (currentToken == "/")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArithmeticException("Invalid expression");
                    }
                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(secondValue / firstValue);
                }
                else if(currentToken == "pow")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArithmeticException("Invalid expression");
                    }
                    double firstValue = stack.Pop();
                    double secondValue = stack.Pop();

                    stack.Push(Math.Pow(secondValue,firstValue));
                }
                else if(currentToken == "sqrt")
                {
                    if (stack.Count < 1)
                    {
                        throw new ArithmeticException("Invalid expression");
                    }
                    double firstValue = stack.Pop();
                    

                    stack.Push(Math.Sqrt(firstValue));
                }
                else if(currentToken == "ln")
                {
                    if (stack.Count < 1)
                    {
                        throw new ArithmeticException("Invalid expression");
                    }
                    double firstValue = stack.Pop();
                    

                    stack.Push(Math.Log(firstValue));
                }
            }
        }
    
    if (stack.Count == 1)
	{
		 return stack.Pop();
	}
    else
	{
        throw new ArgumentException("Exaption");
	}
    }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        PutInvariantCulture();
        input = TrimStringFromSpace(input);
        var separatedTokens = SaparateOperationsAndNums(input);
        var reversePolishNotation = ConvertToReversePolishNotation(separatedTokens);

        var finResult = GetResultFromRPN(reversePolishNotation);

        Console.WriteLine(finResult);
    }
}

