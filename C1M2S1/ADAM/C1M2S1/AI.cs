using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C1M2S1
{
    internal class AI : Player
    {
        Random random = new Random(Guid.NewGuid().GetHashCode());

        public AI(List<Player> players) : base(players)
        {
            this.players = players;
        }

        public string generateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; 
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;
        }

        public override void changeHands()
        {
            while (true)
            {
                Console.WriteLine("【HANDS CHANGE：Please choice a player：】");
                for (int i = 0; i < players.Count; i++)
                {
                    if (players[i].Name != this.Name)
                    {
                        Console.WriteLine($"({i}){players[i].Name}");
                    }
                }
                try
                {
                    while (true)
                    {
                        int choicePlayer = random.Next(3);

                        if (players[choicePlayer].Name != this.Name)
                        {
                            ExchangeHands.swapHands(players[choicePlayer]);
                            return;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("You made wrong decision");
                }
            }
        }

        public override void choice()
        {
            if (this.SwapTurn == 3)
            {
                Console.WriteLine($"{this.Name}'s【swap times up！】");
                ExchangeHands.swapHands(this.ExchangeHands.AsignPlayer);
                ++this.SwapTurn;
            }

            while (true)
            {
                Console.Write($"【{this.Name}'s】 turn ,Please choice (1)Exchange Hands, (2)Show：");
                Thread.Sleep(50);
                string choice = random.Next(1, 3).ToString();
                if (choice == "1")
                {
                    if (this.Exchanged)
                    {
                        choice = "2";
                    }
                    else
                    {
                        changeHands();
                        this.Exchanged = true;
                    }
                }

                if (choice == "2")
                {
                    this.show();
                    while (true)
                    {
                        try
                        {
                            Console.Write($"Your choice：");
                            Thread.Sleep(50);
                            int c = random.Next(this.Hands.Count);
                            Console.Write((c+1).ToString());
                            if (c < this.Hands.Count)
                            {
                                Console.WriteLine($"{this.Name}： choiced one card");
                                ChoiceCard = c;
                                return;
                            }
                        }
                        catch
                        {
                            Console.WriteLine($"Input format error");
                        }
                    }
                }
            }

        }

        public override void nameHimself()
        {
            Console.Write("Please name yourself：");
            Thread.Sleep(50);
            int len = random.Next(3, 10);
            string name = "(AI)" + generateName(len);
            this.Name = name;
            Console.WriteLine($"Hello, {this.Name} Welcome！");
        }
    }
}
