using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Dealer
    {
        Deck PackOfCards { get; set; }



        //changeDeck - discards old deck and makes a new one
        public void changeDeck()
        {
            this.PackOfCards.reset();
        }
        //shuffle - randomizes cards
        public void shuffle()
        {
            this.PackOfCards.randomizeOrder();
        }
        //constructor
        public Dealer()
        {
            this.PackOfCards = new Deck();
            this.shuffle();
        }

        public List<Card> takeHand()
        {
            List<Card> temp= new List<Card>();
            this.shuffle();
            for (int i = 0; i < 4; i++)
            {
                temp.Add(this.PackOfCards.takeCard());
            }
            return temp;
        }
    }
}
