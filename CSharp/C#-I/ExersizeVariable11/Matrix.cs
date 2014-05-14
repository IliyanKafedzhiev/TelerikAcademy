using System;
class matrix
{
    static void Main()
    {
        int number;

        Console.WriteLine("Input a number:");

        number = int.Parse(Console.ReadLine());
        
        int [,] matrix = new int [number,number];
        int c = 1;
        for (int i = 1; i < number; i++)
        {
            
            int cnt = c;
            for (int j = 1; j < number; j++)
            {
                
                    matrix[i, j] = cnt;
                
                
                Console.Write(matrix[i,j] + " ");
                cnt++;
            }
            c++;
            Console.WriteLine();
        }
        
    }
}
