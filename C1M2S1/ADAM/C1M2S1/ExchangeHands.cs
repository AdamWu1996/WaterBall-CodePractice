using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M2S1
{
    internal class ExchangeHands
    {
        private Player my, asignPlayer;

        public ExchangeHands(Player my)
        {
            this.My = my;
        }

        public Player My { get => my; set => my = value; }
        public Player AsignPlayer { get => asignPlayer; set => asignPlayer = value; }


        public void swapHands(Player asignPlayer)
        {
            AsignPlayer = asignPlayer;
            List<Card> tmp = My.Hands;
            My.Hands = asignPlayer.Hands;
            asignPlayer.Hands = tmp;
            Console.WriteLine("Hands swap successfully！");
        }
    }
}
