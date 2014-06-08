using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Game
    {
        NPC player1 { get; set; }
        NPC player2 { get; set; }
        Dealer gameDealer { get; set; }
        GameStats stats { get; set; }

        public GameStats getGameStats()
        {
            return this.stats;
        }


        //public void Game()
        //{

        //}
    }
}
