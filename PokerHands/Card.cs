using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Card
    {
        internal Suit suit { get; set; }
        internal Rank rank { get; set; }
        public int cardValue { get; set; }
        public string valueHolder { get; set; }
        public char suitHolder { get; set; }
        
        public char getLetter() { return this.rank.getLetter(); }
        public int getValue() { return this.rank.getValue(); }
        public string getName() { return this.rank.getName(); }

        /// <summary>
        /// makes new Card from input string 
        /// </summary>
        /// <param name="cardDet">input string</param>
        public Card(string cardDet)
        {
            this.valueHolder = cardDet[0].ToString();
            this.suitHolder = cardDet[1];
            switch (valueHolder)//converts card Letter into a number
            {
                case "2":
                    this.rank = Rank.TWO;
                    break;
                case "3":
                    this.rank = Rank.THREE;
                    break;
                case "4":
                    this.rank = Rank.FOUR;
                    break;
                case "5":
                    this.rank = Rank.FIVE;
                    break;
                case "6":
                    this.rank = Rank.SIX;
                    break;
                case "7":
                    this.rank = Rank.SEVEN;
                    break;
                case "8":
                    this.rank = Rank.EIGHT;
                    break;
                case "9":
                    this.rank = Rank.NINE;
                    break;
                case "T":
                    this.rank = Rank.TEN;
                    break;
                case "J":
                    this.rank = Rank.JACK;
                    break;
                case "Q":
                    this.rank = Rank.QUEEN;
                    break;
                case "K":
                    this.rank = Rank.KING;
                    break;
                case "A":
                    this.rank = Rank.ACE;
                    break;
            }
            switch (suitHolder)
            {
                case 'S':
                    this.suit = Suit.SPADES;
                    break;
                case 'H':
                    this.suit = Suit.HEARTS;
                    break;
                case 'C':
                    this.suit = Suit.CLUBS;
                    break;
                case 'D':
                    this.suit = Suit.DIAMONDS;
                    break;
            }
        }
        
        /// <summary>
        /// writes the cards values to the console
        /// </summary>
        public void talk()
        {
            Console.WriteLine(this.rank.getLetter()+""+this.suit.getPic());
        }

        internal void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
