using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlackJack
{
    class Card
    {
        private int _rank;
        private Suit _suit;
        public bool IsFaceCard => _rank >= 11;
        public bool IsAce => _rank == 1;
        public int Value => 
            IsAce ? 11 : 
            IsFaceCard ? 10 : 
            _rank;

        public string RankName =>
            IsAce ? "Ess" :
            _rank == 13 ? "Konge" :
            _rank == 12 ? "Dame" :
            _rank == 11 ? "Knekt" :
            _rank.ToString();

        public string Description => _suit + " " + RankName + " (" + Value + ")";


        public Card(int rank, Suit suit)
        {
            _rank = rank;
            _suit = suit;
        }
    }
}
