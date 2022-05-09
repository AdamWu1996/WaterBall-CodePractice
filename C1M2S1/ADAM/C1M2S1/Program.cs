using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M2S1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            
            game.Deck.shuffle();
            game.playerDrawCards();
            game.start();
        }
    }
}
