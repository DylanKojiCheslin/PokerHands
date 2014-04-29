using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Program
    {
        static void Main(string[] args)
        {//test cases for each type of hand and one that has the string out of order of value
            Hand test1 = new Hand("10H JH QH KH AH");
            test1.showCards();
            Console.WriteLine(test1.DetermineHandValue());
            Console.WriteLine("royal flush test");
            Console.WriteLine("__________________________________________________________________________________");

            Hand test2 = new Hand("2H 3H 4H 5H 6H");
            test2.showCards();
            Console.WriteLine(test2.DetermineHandValue());
            Console.WriteLine("straight flush test");
            Console.WriteLine("__________________________________________________________________________________");

            Hand test3 = new Hand("QD QS QH QC 3D");
            test3.showCards();
            Console.WriteLine(test3.DetermineHandValue());
            Console.WriteLine("four of a kind test");
            Console.WriteLine("__________________________________________________________________________________");
            
            Hand test4 = new Hand("2D 2S QD QS QH");
            test4.showCards();
            Console.WriteLine(test4.DetermineHandValue());
            Console.WriteLine("full house test");
            Console.WriteLine("__________________________________________________________________________________");

            Hand test5 = new Hand("2D 4D 6D 7D 9D");
            test5.showCards();
            Console.WriteLine(test5.DetermineHandValue());
            Console.WriteLine("flush test");
            Console.WriteLine("__________________________________________________________________________________");

            Hand test6 = new Hand("2D 3S 4D 5H 6S");
            test6.showCards();
            Console.WriteLine(test6.DetermineHandValue());
            Console.WriteLine("straight test");
            Console.WriteLine("__________________________________________________________________________________");

            Hand test7 = new Hand("2D 3H 3S 3D 5H");
            test7.showCards();
            Console.WriteLine(test7.DetermineHandValue());
            Console.WriteLine("three of a kind test");
            Console.WriteLine("__________________________________________________________________________________");

            Hand test8 = new Hand("2D 2H 3D 3H KS");
            test8.showCards();
            Console.WriteLine(test8.DetermineHandValue());
            Console.WriteLine("two pair test");
            Console.WriteLine("__________________________________________________________________________________");

            Hand test9 = new Hand("2D 2H 3D 4H KS");
            test9.showCards();
            Console.WriteLine(test9.DetermineHandValue());
            Console.WriteLine("one pair test");
            Console.WriteLine("__________________________________________________________________________________");

            Hand test10 = new Hand("2D 3H 4D JH KS");
            test10.showCards();
            Console.WriteLine(test10.DetermineHandValue());
            Console.WriteLine("high card test");
            Console.WriteLine("__________________________________________________________________________________");

            Hand test11 = new Hand("AH 10H JH QH KH");
            test11.showCards();
            Console.WriteLine(test11.DetermineHandValue());
            Console.WriteLine("wrong order royal flush test");
            Console.WriteLine("__________________________________________________________________________________");

            Console.ReadKey();
        }
    }
}
