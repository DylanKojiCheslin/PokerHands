using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Card
    {
        public char Suit { get; set; }
        public int Value { get; set; }
        string valueHolder { get;  set; }
        char suitHolder { get; set; }
    


        /// <summary>
        /// makes new Card from input string 
        /// </summary>
        /// <param name="cardDet">input string</param>
        public Card(string cardDet)
        {

            if (cardDet.Length != 3)//turns string input into card attributes
            {
                this.valueHolder = cardDet[0].ToString();
                this.suitHolder = cardDet[1];
            }
            else//if the input is 10 turns string input into card attributes
            {
                this.valueHolder = cardDet[0].ToString() +cardDet[1].ToString();
                this.suitHolder = cardDet[2];
            }
            switch (valueHolder)//converts card value ie king into a number
            {
                case "2":
                    this.Value = 2;
                    break;
                case "3":
                    this.Value = 3;
                    break;
                case "4":
                    this.Value = 4;
                    break;
                case "5":
                    this.Value = 5;
                    break;
                case "6":
                    this.Value = 6;
                    break;
                case "7":
                    this.Value = 7;
                    break;
                case "8":
                    this.Value = 8;
                    break;
                case "9":
                    this.Value = 9;
                    break;
                case "10":
                    this.Value = 10;
                    break;
                case "J":
                    this.Value = 11;
                    break;
                case "Q":
                    this.Value = 12;
                    break;
                case "K":
                    this.Value = 13;
                    break;
                case "A":
                    this.Value = 14;
                    break;

            }
            this.Suit = suitHolder;//asigns card suit
        }// constructor
        /// <summary>
        /// writes the cards values to the console
        /// </summary>
        public void talk()
        {
            Console.WriteLine(this.valueHolder+this.Suit);
        }
    }
}
