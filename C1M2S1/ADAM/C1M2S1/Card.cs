using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M2S1
{
    public class Card
    {
        private Player owner;
        private Suit suit;
        private Rank rank;
        private Compare compare;

        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
            compare = new Compare(this);
        }

        public Rank Rank1 { get => rank; set => rank = value; }
        public Suit Suit1 { get => suit; set => suit = value; }
        internal Player Owner { get => owner; set => owner = value; }
        internal Compare Compare { get => compare; set => compare = value; }

        public enum Suit
        {
            CLUB, DIAMOND, HEART, SPADE
        }

        public enum Rank
        {
            TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, J, Q, K, A
        }

        public string getCardName()
        {
            string rank = "", suit = "";
            //switch (Suit1)
            //{
            //    case Suit.CLUB:
            //        suit = "♣";
            //        break;

            //    case Suit.DIAMOND:
            //        suit = "♦";
            //        break;

            //    case Suit.HEART:
            //        suit = "♥";
            //        break;

            //    case Suit.SPADE:
            //        suit = "♠";
            //        break;
            //}

            switch (Rank1)
            {
                case Rank.TWO:
                    rank = "2";
                    break;

                case Rank.THREE:
                    rank = "3";
                    break;

                case Rank.FOUR:
                    rank = "4";
                    break;

                case Rank.FIVE:
                    rank = "5";
                    break;

                case Rank.SIX:
                    rank = "6";
                    break;

                case Rank.SEVEN:
                    rank = "7";
                    break;

                case Rank.EIGHT:
                    rank = "8";
                    break;

                case Rank.NINE:
                    rank = "9";
                    break;

                case Rank.TEN:
                    rank = "10";
                    break;

                case Rank.J:
                    rank = "J";
                    break;

                case Rank.Q:
                    rank = "Q";
                    break;

                case Rank.K:
                    rank = "K";
                    break;

                case Rank.A:
                    rank = "A";
                    break;
            }

            return $"{Suit1} {rank}";
        }
    }
}