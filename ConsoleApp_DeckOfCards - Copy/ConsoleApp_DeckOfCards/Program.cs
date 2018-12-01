using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            string choice;
            string dealt_Card;
            List<string> playerHand = new List<string>();
            List<string> dealerHand = new List<string>();
            int playerValue;
            int dealerValue;

            //NumPlayers = 2; // Dealer and human player
            // create new deck object first            
            // Shuffle the deck and generate the stack
            newDeck.Shuffle_Deck();

            // Deal the cards to the player and the dealer
            playerHand.Add(newDeck.Deal_Card());
            playerHand.Add(newDeck.Deal_Card());
            playerHand.ForEach(Console.WriteLine);
            playerValue = newDeck.Card_Value(playerHand[0]);
            dealerValue = newDeck.Card_Value(playerHand[1]);
            Console.WriteLine(playerValue);
            Console.WriteLine(dealerValue);
            Console.WriteLine();
           

            //playerValue = newDeck.Card_Value(strings.for);
            //Console.WriteLine();

            dealerHand.Add(newDeck.Deal_Card());
            //dealerValue = newDeck.Card_Value();

            playerHand.Add(newDeck.Deal_Card());
            //playerValue = newDeck.Card_Value();
            playerHand.ForEach(Console.WriteLine);

            dealerHand.Add(newDeck.Deal_Card());
            //dealerValue = newDeck.Card_Value();

            // Print the Hands out
            while (true)
            {
                Console.WriteLine("Press 's' shuffle the deck of cards.");
                Console.WriteLine("Press 'd' deal the deck of cards.");
                Console.WriteLine("Press 'c' count current number of cards in the deck.");
                choice = Console.ReadLine();
                if(choice == "s")
                {
                    ShuffledDeck(newDeck);
                }
                if(choice == "d")
                {
                    dealt_Card = newDeck.Deal_Card();
                    Console.WriteLine(dealt_Card);
                    Console.WriteLine(newDeck.Card_Value(dealt_Card));
                }
                if(choice == "c")
                {
                    newDeck.CardsInStack();
                }
                Console.WriteLine();
            }
        }

        public static void ShuffledDeck(Deck newDeck)
        {
            newDeck.Shuffle_Deck();
            int count = 1;

            for (int i = 0; i < 52; i++, count++)
            {
                Console.Write("{0,  -10}", newDeck.ReturnCards(i));
                if ((count % 4) == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }


    }
}