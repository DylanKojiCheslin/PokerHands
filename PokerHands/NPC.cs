using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class NPC
    {
        //hand of cards
        Hand handOfCards { get; set; }

        //name of charicter
        string name { get; set; }

        //what it shows ie tells
        public string getHandValue()
        {
            return this.handOfCards.GetHandValue();
        }
        //returns name
        public string getName()
        {
            return this.name;
        }
        //sets hand to Hand Obj
        public void setHand(Hand newHand)
        {
            this.discardHand();
            this.handOfCards = newHand;
        }
        //sets hand to string passed
        public void setHand(string newHand)
        {
            this.discardHand();
            this.setHand(new Hand(newHand));
        }

        public void discardHand()
        {
            this.handOfCards.discardHand();
        }

        public  NPC(string newHandString, string newName)
        {
            handOfCards = new Hand(newHandString);
            name = newName;
        }


        public  NPC(Hand newHand, string newName)
        {
            handOfCards = newHand;
            name = newName;
        }
    }
}
