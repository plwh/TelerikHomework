/* Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
Use 2 nested for-loops and a switch-case statement. */

using System;

class PrintA52CardsDeck
{
    static void Main()
    {
        var card = "";
        for (int i = 2; i<=14;i++)
        {
            switch(i)
            {
                    case 2:card = i.ToString(); break;
                    case 3:card = i.ToString(); break;
                    case 4:card = i.ToString(); break;
                    case 5:card = i.ToString(); break;
                    case 6:card = i.ToString(); break;
                    case 7: card = i.ToString();break;
                    case 8: card = i.ToString();break;
                    case 9: card = i.ToString(); break;
                    case 10: card = i.ToString(); break;
                    case 11: card = "J"; break;
                    case 12: card = "Q"; break;
                    case 13: card = "K"; break;
                    case 14: card = "A"; break;
            }
            for(int j=1;j<=4;j++)
            {
                switch (j)
                {
                case 1:
                    Console.Write(card +" of "+'\u2660'+",");
                    break;
                case 2:
                    Console.Write(" " + card + " of "+'\u2663'+",");
                    break;
                case 3:
                    Console.Write(" " + card + " of "+'\u2665'+",");
                    break;
                case 4:
                    Console.WriteLine(" " + card + " of "+'\u2666');
                    break;           
                }
            }
        }
    }        
}

