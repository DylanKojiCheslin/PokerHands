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
        public static readonly Suit SPADES = new Suit("Spades", '\u2660', "Black");

        private string name;
        private char pic;
        private string color;

        public string getName() { return this.name; }
        public char getPic() { return this.pic; }
        private string getColor() { return this.color; }

        private Suit(string thisName, char thisPic, string thisColor)
        {
            name = thisName;
            pic = thisPic;
            color = thisColor;
        }
    }
}
