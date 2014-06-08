using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Deck
    {
        public List<Card> guts {get; set;}
        /// <summary>
        /// creates a Card obj of each suit value combination and adds them to guts list
        /// </summary>
        public void fillDeck()
        {
            //todo change deck creation to take 2 inputs of suit class and values class, run foreach loop of all value/suit combos to make it reactive in creation
            char suitHolder='Z';
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        suitHolder = 'C';
                        break;
                    case 1:
                        suitHolder = 'D';
                        break;
                    case 2:
                        suitHolder = 'H';
                        break;
                    case 3:
                        suitHolder = 'S';
                        break;
                    default:
                        break;
                }
                for (int x = 2; x < 15; x++)
                {
                    switch (x)
                    {
                        case 2:
                            guts.Add(new Card("2" + suitHolder.ToString()));
                            break;
                        case 3:
                            this.guts.Add(new Card(3 + "" + suitHolder));
                            break;
                        case 4:
                            this.guts.Add(new Card(4 + "" + suitHolder));
                            break;
                        case 5:
                            this.guts.Add(new Card(5 + "" + suitHolder));
                            break;
                        case 6:
                            this.guts.Add(new Card(6 + "" + suitHolder));
                            break;
                        case 7:
                            this.guts.Add(new Card(7 + "" + suitHolder));
                            break;
                        case 8:
                            this.guts.Add(new Card(8 + "" + suitHolder));
                            break;
                        case 9:
                            this.guts.Add(new Card(9 + "" + suitHolder));
                            break;
                        case 10:
                            this.guts.Add(new Card(10 + "" + suitHolder));
                            break;
                        case 11:
                            this.guts.Add(new Card('J' + "" + suitHolder));
                            break;
                        case 12:
                            this.guts.Add(new Card('Q' + "" + suitHolder));
                            break;
                        case 13:
                            this.guts.Add(new Card('K' + "" + suitHolder));
                            break;
                        case 14:
                            this.guts.Add(new Card('A' + "" + suitHolder));
                            break;
                        default:
                            break;
                    }
                }

            }
        }
        /// <summary>
        /// displays all cards in the deck to the console
        /// </summary>
        public void sayCards()
        {
            foreach (var x in this.guts)
            {
                x.talk();
            }
        }
        /// <summary>
        /// randomizes the order of the cards in the deck
        /// </summary>
        public void randomizeOrder()
        {
            Random rand = new Random();
            this.guts = this.guts.OrderBy(c => rand.Next()).Select(c => c).ToList();
        }

        public void reset()
        {
            this.guts.Clear();
            this.fillDeck();
            this.randomizeOrder();
        }
        /// <summary>
        /// constructor
        /// </summary>
        public Deck()
        {
            guts = new List<Card>();
            this.fillDeck();
        }


        //return  the first card and remove it from list
        public Card takeCard()
        {
            Card tempcard = guts.First();
            guts[0].Remove();
            return tempcard;
        }
    }
}
