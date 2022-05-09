using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M2S1
{
    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            foreach (Card.Suit suit in (Card.Suit[])Enum.GetValues(typeof(Card.Suit))) 
            {
                foreach (Card.Rank rank in (Card.Rank[])Enum.GetValues(typeof(Card.Rank)))
                {
                    Card card = new Card(suit, rank);
                    cards.Add(card);
                }
            }
        }

        internal List<Card> Cards 
        { get => cards; set => cards = value; }

        public void shuffle()
        {
            Console.WriteLine("Shuffle the deck...");
            cards = cards.OrderBy(a => Guid.NewGuid()).ToList();
            Console.WriteLine("The deck is shuffled completely...");
        }
    }
}
