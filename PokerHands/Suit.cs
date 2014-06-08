using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    public class Suit
    {
        public static readonly Suit CLUBS = new Suit("Clubs", '\u2663', "Red");
        public static readonly Suit DIAMONDS = new Suit("Diamonds", '\u2666', "Black");
        public static readonly Suit HEARTS = new Suit("Hearts", '\u2665', "Red");
        public static readonly Suit SPADES = new Suit("Spades", '\u2660', "Red");

        private string name;
        private char pic;
        private string color;
        private char suitHolder;

        private Suit(string thisName, char thisPic, string thisColor)
        {
            name = thisName;
            pic = thisPic;
            color = thisColor;
        }

        //change access level
        public Suit(char suitChar)
        {
            switch (suitChar)
            {
                case'C':
                    this.name = "Clubs";
                    this.pic = '\u2663';
                    this.color = "Red";
                    break;
                case'D':
                    this.name = "Diamonds";
                    this.pic = '\u2666';
                    this.color = "Black";
                    break;
                case'H':
                    this.name = "Hearts";
                    this.pic = '\u2665';
                    this.color = "Red";
                    break;
                case'S':
                    this.name = "Spades";
                    this.pic = '\u2660';
                    this.color = "Red";
                    break;
                default:
                    //todo error handling
                    break;
            }
        }
        //change access level
        public string getName()
        {
            return this.name;
        }
        //change access level
        public char getPic()
        {
            return this.pic;
        }

        private string getColor()
        {
            return this.color;
        }
    }
}
