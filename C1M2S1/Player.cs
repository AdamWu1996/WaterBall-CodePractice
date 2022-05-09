using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M2S1
{
    public abstract class Player
    {
        private string name;
        private int choiceCard;
        private List<Card> hands = new List<Card>();
        private int points = 0;
        private bool exchanged = false;
        public List<Player> players;
        private ExchangeHands exchangeHands;
        private int swapTurn = 0;

        protected Player(List<Player> players)
        {
            ExchangeHands = new ExchangeHands(this);
            this.players = players;
        }

        public string Name { get => name; set => name = value; }
        public int Points { get => points; set => points = value; }
        public bool Exchanged { get => exchanged; set => exchanged = value; }
        public List<Card> Hands { get => hands; set => hands = value; }
        public int ChoiceCard { get => choiceCard; set => choiceCard = value; }
        internal ExchangeHands ExchangeHands { get => exchangeHands; set => exchangeHands = value; }
        public int SwapTurn { get => swapTurn; set => swapTurn = value; }

        public abstract void choice();
        public abstract void nameHimself();
        public abstract void changeHands();

        public void drawCard(Card card)
        {
            if (hands.Count >= 13)
            {
                Console.WriteLine($"{name}:hands are full");
                return;
            }

            hands.Add(card);
            card.Owner = this;
        }

        public void show()
        {
            Console.WriteLine($"{name}:Please choice a card.");
            Console.WriteLine($"=====================================");
            for (int i = 0; i < hands.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{hands[i].getCardName()}");
            }
            Console.WriteLine($"=====================================");
        }

    }
}
