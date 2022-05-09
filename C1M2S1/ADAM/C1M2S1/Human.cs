using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M2S1
{
    internal class Human : Player
    {
        public Human(List<Player> players) : base(players)
        {
            this.players = players;
        }

        public override void changeHands()
        {
            while (true)
            {
                Console.WriteLine("【HANDS CHANGE：Please choice a player：】");
                for(int i = 0; i < players.Count; i++)
                {
                    if (players[i].Name != this.Name)
                    {
                        Console.WriteLine($"({i}){players[i].Name}");
                    }
                }
                try
                {
                    int choicePlayer = Convert.ToInt32(Console.ReadLine());

                    if (players[choicePlayer].Name != this.Name)
                    {
                        ExchangeHands.swapHands(players[choicePlayer]);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You made wrong decision");
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
                Console.Write($"【{this.Name}'s turn】,Please choice (1)Exchange Hands, (2)Show：");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    if (this.Exchanged)
                    {
                        Console.WriteLine($"{this.Name}：This method only can be used once！");
                        choice = "2";
                    }
                    else
                    {
                        changeHands();
                        this.Exchanged = true;
                    }
                }
                else if (choice == "2")
                {
                    this.show();
                    while (true)
                    {
                        try
                        {
                            Console.Write($"Your choice：");
                            int c = Convert.ToInt32(Console.ReadLine());
                            if (--c < this.Hands.Count)
                            {
                                Console.WriteLine($"{this.Name}： choiced one card");
                                ChoiceCard = c;
                                return;
                            }
                            else
                            {
                                Console.WriteLine($"Index out of range");
                            }
                        }
                        catch
                        {
                            Console.WriteLine($"Input format error");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{this.Name}：You made wrong decision！");
                }
            }
                
        }

        public override void nameHimself()
        {
            Console.Write("Please name yourself：");
            string name = Console.ReadLine();
            this.Name = name;
            Console.WriteLine($"Hello, {this.Name} Welcome！");
        }
    }
}
