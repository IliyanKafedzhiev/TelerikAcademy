using System;
class BonusScores
{

    static void Main()
    {
        for (int i = 1; i < 14; i++)
        {

            for (int j = 1; j < 5; j++)
            {
                string name="";
                switch (i)
                {
                    case 1:
                        name = "Ace";
                        break;
                    case 2:
                        name = "Deuce";
                        break;
                    case 3:
                        name = "Three";
                        break;
                    case 4:
                        name = "Four";
                        break;
                    case 5:
                        name = "Five";
                        break;
                    case 6:
                        name = "Six";
                        break;
                    case 7:
                        name = "Seven";
                        break;
                    case 8:
                        name = "Eight";
                        break;
                    case 9:
                        name = "Nine";
                        break;
                    case 10:
                        name = "Ten";
                        break;
                    case 11:
                        name = "Jack";
                        break;
                    case 12:
                        name = "Queen";
                        break;
                    case 13:
                        name = "King";
                        break;
                    default:
                        break;
                }

                string color = "";

                switch (j)
                {
                    case 1:
                        color = "clubs";
                        break;
                    case 2:
                        color = "diamonds";
                        break;
                    case 3 :
                        color = "hearts";
                        break;
                    case 4:
                        color = "spades";
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Card {0}-{1}",name,color);
            }
        }

    }
}
