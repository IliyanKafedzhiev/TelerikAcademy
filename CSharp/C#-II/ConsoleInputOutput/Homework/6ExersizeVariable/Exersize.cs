using System;
class Exersize
{
    static void Main()
    {
        decimal a;
        decimal b;
        decimal c;
        Console.WriteLine("intput a:");
        a = decimal.Parse(Console.ReadLine());
        Console.WriteLine("intput b:");
        b= decimal.Parse(Console.ReadLine());
        Console.WriteLine("intput c:");
        c = decimal.Parse(Console.ReadLine());
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("There aren't real solution");
            }
            else
            {
                if (c==0)
                {
                    Console.WriteLine("There is one real solution X1:0");
                }
                decimal solutionOne;
                solutionOne = (-c) / b;
                Console.WriteLine("There is one real solution X1:", solutionOne);
            }
            
        }
        else
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("There is one real solution X1:0");
                }
                else
	            {
                    decimal solutionOne = (decimal)Math.Sqrt((double)((-c) / a));
                    decimal solutionTwo = -(decimal)Math.Sqrt((double)((-c) / a));
                    Console.WriteLine("There are two real solution X1:{0} and X2:{1}", solutionOne, solutionTwo);
	            }
                
            }
            else
            {
                if (c==0)
                {
                    decimal solutionOne = (-b) / a;
                    Console.WriteLine("There are two real solution X1:{0} and X2:0", solutionOne);
                }
                else
                {
                    decimal Determinant = b * b - 4 * a * c;
                    if (Determinant >= 0)
                    {

                        decimal solutionOne = (-b + (decimal)Math.Sqrt((double)Determinant)) / (2 * a);
                        decimal solutionTwo = (-b - (decimal)Math.Sqrt((double)Determinant)) / (2 * a);
                        Console.WriteLine("There are two real solution X1:{1} and X2:{0}", solutionOne, solutionTwo);
                    }
                    else
                    {
                        Console.WriteLine("There aren't real solution for equation!");
                    }     
                }
            }
            
        }
    }
}
