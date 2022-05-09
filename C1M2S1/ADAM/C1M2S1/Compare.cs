using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M2S1
{
    internal class Compare
    {
        Card card;

        public Compare(Card card)
        {
            this.Card = card;
        }

        public Card Card { get => card; set => card = value; }

        public Card compare(Card compareCard)
        {
            if (card.Rank1 > compareCard.Rank1)
            {
                return card;
            }

            if (compareCard.Rank1 > card.Rank1)
            {
                return compareCard;
            }

            if (card.Suit1 > compareCard.Suit1)
            {
                return card;
            }

            return compareCard;
        }
    }
}
