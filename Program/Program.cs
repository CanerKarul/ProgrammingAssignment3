using System;
using ConsoleCards;

namespace ProgrammingAssignment3
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 3
    /// </summary>
    class Program
    {
        /// <summary>
        /// Programming Assignment 3
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // declare a deck variables and create a deck object
                // DON'T SHUFFLE THE DECK
                Deck deck = new Deck();

                // deal 2 cards each to 4 players (deal properly, dealing
                // the first card to each player before dealing the
                // second card to each player)
                Card card1 = deck.TakeTopCard();
                Card card2 = deck.TakeTopCard();
                Card card3 = deck.TakeTopCard();
                Card card4 = deck.TakeTopCard();
                Card card11 = deck.TakeTopCard();
                Card card22 = deck.TakeTopCard();
                Card card33 = deck.TakeTopCard();
                Card card44 = deck.TakeTopCard();

                // deal 1 more card to players 2 and 3
                Card card222 = deck.TakeTopCard();
                Card card333 = deck.TakeTopCard();

                // flip all the cards over
                card1.FlipOver();
                card11.FlipOver();
                card2.FlipOver();
                card22.FlipOver();
                card222.FlipOver();
                card3.FlipOver();
                card33.FlipOver();
                card333.FlipOver();
                card4.FlipOver();
                card44.FlipOver();

                // print the cards for player 1
                Console.WriteLine(card1.Rank + "," + card1.Suit);
                Console.WriteLine(card11.Rank + "," + card11.Suit);

                // print the cards for player 2
                Console.WriteLine(card2.Rank + "," + card2.Suit);
                Console.WriteLine(card22.Rank + "," + card22.Suit);
                Console.WriteLine(card222.Rank + "," + card222.Suit);

                // print the cards for player 3
                Console.WriteLine(card3.Rank + "," + card3.Suit);
                Console.WriteLine(card33.Rank + "," + card33.Suit);
                Console.WriteLine(card333.Rank + "," + card333.Suit);

                // print the cards for player 4
                Console.WriteLine(card4.Rank + "," + card4.Suit);
                Console.WriteLine(card44.Rank + "," + card44.Suit);

                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }
    }
}