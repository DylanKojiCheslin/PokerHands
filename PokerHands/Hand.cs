using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Hand
    {
        List<Card> Cards { get; set; }//the card obj in the hand
        public string handType { get; set; }//string recording the type of hand ie flush, two pair, etc
        public bool scoreFound { get; set; }//tells if the search for a hand type is over
        public bool fullHand { get; set; }//not used currently
        /// <summary>
        /// tells if the hand is full
        /// </summary>
        /// <returns>bool if hand is full</returns>
        public bool isFullHand()
        {
            return fullHand;
        }//not used currently
        /// <summary>
        /// displays the values and suit of each card
        /// </summary>
        public void showCards()//displays cards in the hand to the console
        {
            Console.WriteLine(" ");
            foreach ( Card x in this.Cards)
            {
                Console.Write(x.Value.ToString() + "" + x.suit.getPic().ToString() + " ");
            }
        }
        /// <summary>
        /// sets the type of hand ie flush, fullhouse, two pair
        /// </summary>
        public void DetermineHandValue()
        {
            //royal flush-10 J,Q,K,A all same suit
            if (!scoreFound)
            {
                handIsRoyalFlush();
            }
            //straight flush-all cards are consectutive values of the samenumber
            if (!scoreFound)
            {
                handIsStraightFlush();
            }
            //four of a kind-four cards of the same value
            if (!scoreFound)
            {
                handIsFourOfAKind();
            }
            //full house- three cards of same value and two cards of the same value
            if (!scoreFound)
            {
                handIsFullHouse();
            }
            //flush- all cards are of the same suit
            if (!scoreFound)
            {
                handIsFlush();
            }
            //straight- all cards are consecutive values
            if (!scoreFound)
            {
                handIsStraight();
            }
            //three of a kind- three cards of the same value
            if (!scoreFound)
            {
                handIsThreeOfAKind();
            }
            //two pair-two sets of two cards of the same value
            if (!scoreFound)
            {
                handIsTwoPair();
            }
            //one pair-two cards of the same value
            if (!scoreFound)
            {
                handIsOnePair();
            }
            //high card-the highest value card in the hand
            if (!scoreFound)
            {
                handIsHighCard();
            }
        }
        /// <summary>
        /// returns the hands' value
        /// </summary>
        /// <returns>string hands' value</returns>
        public string GetHandValue()
        {
            if (this.handType == null)
            {
                this.DetermineHandValue();
            }
            return this.handType;
        }
        /// <summary>
        /// return a true bool if all cards are the same suit
        /// </summary>
        /// <returns>bool true if all same suit</returns>
        public bool isFlush()//tests if all cards are same suit
        {
            bool returnHolder = false;
            int same = this.Cards.Where(x=> x.suit.getName() == this.Cards.First().suit.getName()).Count();
            if (same == 5)
            {
                returnHolder = true;
            }
            return returnHolder;
        }
        /// <summary>
        /// method tests if all cards are consecutive values
        /// </summary>
        /// <returns>bool true if all cards are consecutive values</returns>
        public bool isStraight()//tests if all cards are consecutive values
        {
            bool returnHolder = false;
            if (((this.Cards.Last().Value) - (this.Cards.First().Value)) == 4 && (numOfDistinctCardValues() == 5))
            {
                returnHolder = true;
            }
            return returnHolder;
        }
        /// <summary>
        /// method returns the number of distinct card values as an int
        /// </summary>
        /// <returns>int distinct values of cards</returns>
        public int numOfDistinctCardValues()
        {
            return this.Cards.Select(x => x.Value).Distinct().Count();
        }
        /// <summary>
        /// tests if the hand is a royal flush
        /// </summary>
        public void handIsRoyalFlush()
        {
            if (isFlush() && isStraight() && this.Cards.OrderBy(x => x.Value).Last().Value == 14)//test if all one suit, consecutive order, highest value card is ace 
	        {
                this.handType = "Royal Flush";
                this.scoreFound = true;
	        }
        }
        /// <summary>
        /// tests if the hand is a straight flush
        /// </summary>
        public void handIsStraightFlush()
        {
            if (isFlush() && isStraight())//test if all one suit, consecutive order
            {
                this.handType = "Straight Flush";
                this.scoreFound = true;
            }
        }
        /// <summary>
        /// tests if the hand is four of a kind
        /// </summary>
        public void handIsFourOfAKind()
        {
            if (numOfDistinctCardValues() == 2 && (this.Cards.First().Value == this.Cards[3].Value || this.Cards[1].Value == this.Cards.Last().Value))//tests if there are 2 distinct card values and if four of them are the same
            {
                this.handType = "Four Of A Kind";
                this.scoreFound = true;
            }
        }
        /// <summary>
        /// tests if the hand is a full house
        /// </summary>
        public void handIsFullHouse()
        {
            if (numOfDistinctCardValues() == 2 && (this.Cards.First().Value == this.Cards[2].Value&&this.Cards[3].Value==this.Cards[4].Value||this.Cards.First().Value == this.Cards[1].Value&&this.Cards[2].Value==this.Cards[4].Value))//test if there are 2 distinct card values and 3 of one and 2 of the other
            {
                this.handType = "Full House";
                this.scoreFound = true;
            }
        }
        /// <summary>
        /// tests if the hand is a flush
        /// </summary>
        public void handIsFlush()
        {
            if (this.isFlush())//tests if all cards are same suit
            {
                this.handType = "Flush";
                this.scoreFound = true;
            }
        }
        /// <summary>
        /// tests if the hand is a straight
        /// </summary>
        public void handIsStraight()
        {
            if (this.isStraight())//tests if all cards are consecutive values
            {
                this.handType = "Straight";
                this.scoreFound = true;
            }
        }
        /// <summary>
        /// tests if hand is three of a kind
        /// </summary>
        public void handIsThreeOfAKind()
        {
            if (this.Cards.First().Value == this.Cards[2].Value||this.Cards[1].Value == this.Cards[3].Value||this.Cards[2].Value == this.Cards[4].Value)//tests if three of the cards have the same value
            {
                this.handType = "Three Of A Kind";
                this.scoreFound = true;
            }
        }
        /// <summary>
        /// tests if the hand is a two pair
        /// </summary>
        public void handIsTwoPair()
        {
            if (this.numOfDistinctCardValues() ==3 )//tests if the hand has 3 distinct Card Values
            {
                this.handType = "Two Pair";
                this.scoreFound = true;
            }
        }
        /// <summary>
        /// tests if the hand is a one pair
        /// </summary>
        public void handIsOnePair()
        {
            if (this.numOfDistinctCardValues() == 4)//tests if the hand has 3 distinct Card Values
            {
                this.handType = "One Pair";
                this.scoreFound = true;
            }
        }
        /// <summary>
        /// default case makes the hands type high card
        /// </summary>
        public void handIsHighCard()
        {
            this.handType = "High Card: " + this.Cards.OrderByDescending(x => x.Value).First().Value + " " + this.Cards.OrderByDescending(x => x.Value).First().suit.getName();
            this.scoreFound = true;
        }
        /// <summary>
        /// construtor for hand class works with string input
        /// </summary>
        /// <param name="handString">string of card values</param>
        public Hand(string handString)
        {
            string[] units = handString.Split(' ');//takes string and splits into array
            List<Card> storage = new List<Card>();//makes an empty storage list of cards
            foreach (var x in units)//constructs and adds cards to storage list
            {
                storage.Add(new Card(x));
            }
            this.Cards = new List<Card>(storage.OrderBy(x => x.Value));//makes a new list and populates it with the sorted cards from the storage list
            this.scoreFound = false;//sets scorefound to false
            this.fullHand = true;
            this.DetermineHandValue();
        }
        /// <summary>
        /// construtor for hand class works with list input
        /// </summary>
        /// <param name="newCards">List(cards) </param>
        public Hand( List<Card> newCards)
        {
            this.Cards = newCards;
            this.scoreFound = false;
            this.fullHand = true;
            this.DetermineHandValue();
        }


        public void discardHand()
        {
            this.Cards.Clear();
        }


    }
}
