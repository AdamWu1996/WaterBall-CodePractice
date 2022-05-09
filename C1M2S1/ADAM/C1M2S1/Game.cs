using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M2S1
{
    public class Game
    {
        public int turn = 0;
        private bool isHandsChange = false;
        private Player currentPlayer = null;
        public List<Player> players;
        private Deck deck;
        private Player p1, p2, p3, p4;

        public Game()
        {
            players = new List<Player>();
            deck = new Deck();
            Console.WriteLine("【 Welcome To Poker Game ！！】");

            p1 = new AI(players);
            p2 = new AI(players);
            p3 = new AI(players);
            p4 = new AI(players);

            players.Add(p1);
            players.Add(p2);
            players.Add(p3);
            players.Add(p4);

            p1.nameHimself();
            p2.nameHimself();
            p3.nameHimself();
            p4.nameHimself();
        }

        public int Turn { get => turn; set => turn = value; }
        public bool IsHandsChange { get => isHandsChange; set => isHandsChange = value; }
        public Player CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public List<Player> Players { get => players; set => players = value; }
        public Deck Deck { get => deck; set => deck = value; }

        public void playerDrawCards()
        {
            Console.WriteLine("Draw crads...");
            while(deck.Cards.Count > 0)
            {
                p1.drawCard(deck.Cards[0]);
                deck.Cards.RemoveAt(0);

                p2.drawCard(deck.Cards[0]);
                deck.Cards.RemoveAt(0);

                p3.drawCard(deck.Cards[0]);
                deck.Cards.RemoveAt(0);

                p4.drawCard(deck.Cards[0]);
                deck.Cards.RemoveAt(0);
            }

            Console.WriteLine($"{players[0].Name}：Have {players[0].Hands.Count} cards now.");
            Console.WriteLine($"{players[1].Name}：Have {players[1].Hands.Count} cards now.");
            Console.WriteLine($"{players[2].Name}：Have {players[2].Hands.Count} cards now.");
            Console.WriteLine($"{players[3].Name}：Have {players[3].Hands.Count} cards now.");
        }

        public void start()
        {
            for (turn = 0; turn < 13; turn++)
            {
                foreach (var player in players)
                {
                    player.choice();

                    if (player.Exchanged && player.SwapTurn < 3)
                    {
                        player.SwapTurn++;
                    }
                }
                showCards();
            }
            showWinner();
        }

        public void showCards()
        {
            Console.WriteLine("【Show the cards】");

            foreach (var player in players)
            {
                Console.WriteLine($"{player.Name}：{player.Hands[player.ChoiceCard].getCardName()}");
            }

            Card biggestCard = players[0].Hands[players[0].ChoiceCard].Compare.compare(players[1].Hands[players[1].ChoiceCard]);
            biggestCard = biggestCard.Compare.compare(players[2].Hands[players[2].ChoiceCard]);
            biggestCard = biggestCard.Compare.compare(players[3].Hands[players[3].ChoiceCard]);

            Console.WriteLine($"【The biggest card is：{biggestCard.Owner.Name}】");
            Console.WriteLine($"【{biggestCard.Owner.Name} get 1 point, current points：{++biggestCard.Owner.Points}】");
            removeCards();
        }

        public void removeCards()
        {
            players[0].Hands.RemoveAt(players[0].ChoiceCard);
            players[1].Hands.RemoveAt(players[1].ChoiceCard);
            players[2].Hands.RemoveAt(players[2].ChoiceCard);
            players[3].Hands.RemoveAt(players[3].ChoiceCard);
        }

        public void showWinner()
        {
            int winnerIdx = 0, points = 0;

            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Points > points)
                {
                    winnerIdx = i;
                    points = players[i].Points;
                }
            }
            Console.WriteLine("**********************************************");
            Console.WriteLine($"GameOver, The Winner is 【{players[winnerIdx].Name}】, Points：{players[winnerIdx].Points}！！");
            Console.WriteLine("**********************************************");
            Console.ReadLine();
        }
    }
}
