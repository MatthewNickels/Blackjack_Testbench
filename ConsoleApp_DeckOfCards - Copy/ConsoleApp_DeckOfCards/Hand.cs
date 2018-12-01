using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DeckOfCards
{
    class Hand : Deck
    {
        private int handValue { get; set; }

        /// <summary>
        /// Default constructor will deal two cards 
        /// </summary>
        public Hand()
        {
            string dealt_Card = "";
            dealt_Card = this.Deal_Card();
        }
        /// <summary>
        /// This is a helper method which will recur everytime a card is dealt to check for a 
        /// busted state, then it will trigger an event to signal this event
        /// </summary>
        private void checkBusted()
        {
            if (handValue > 21) { }
            //TODO: trigger event on GamePage to signify a busted hand
        }
    }
}
