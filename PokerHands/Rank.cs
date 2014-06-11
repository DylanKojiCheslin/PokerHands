using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Rank
    {
        private char letter { get; set; }
        private int value { get; set; }
        private string name { get; set; }

        public char getLetter() { return this.letter; }
        public int getValue() { return this.value; }
        public string getName() { return this.name; }


        public Rank(char C, int value, string name)
        {
            this.letter = C;
            this.value = value;
            this.name = name;
        }

        public static readonly Rank TWO = new Rank( '2', 2, "two" );
        public static readonly Rank THREE = new Rank( '3', 3, "three" );
        public static readonly Rank FOUR = new Rank( '4', 4, "four" );
        public static readonly Rank FIVE = new Rank( '5', 5, "five" );
        public static readonly Rank SIX = new Rank( '6', 6, "six" );
        public static readonly Rank SEVEN = new Rank( '7', 7, "seven" );
        public static readonly Rank EIGHT = new Rank( '8', 8, "eight" );
        public static readonly Rank NINE = new Rank( '9', 9, "nine" );
        public static readonly Rank TEN = new Rank( 'T', 10,"ten" );
        public static readonly Rank JACK = new Rank( 'J', 11,"jack" );
        public static readonly Rank QUEEN = new Rank( 'Q', 12,"queen" );
        public static readonly Rank KING = new Rank( 'K', 13,"king" );
        public static readonly Rank ACE = new Rank( 'A', 14,"ace" );
    }
}
