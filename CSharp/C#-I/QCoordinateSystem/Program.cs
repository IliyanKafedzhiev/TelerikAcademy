using System;
using System.Numerics;


 class QCoordinateSystem
{
    static void Main()
    {
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());

        int zone = -1;

        if (x>0 && y>0)
        {
            zone = 1;
        }
        else if (x<0 && y>0)
        {
            zone = 2;
        }
        else if (x<0 && y<0)
        {
            zone = 3;
        }
        else if (x>0 && y<0)
        {
            zone = 4;
        }
        else if (x == 0 && y == 0 )
        {
            zone = 0;
        }
        else if (x == 0 && y != 0 )
        {
            zone = 5;
        }
        else if (x != 0 && y == 0)
	    {
            zone = 6;
	    }
        Console.WriteLine(zone);
        


    }
}

