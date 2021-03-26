using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlackJack
{
    class Player
    {
        private List<Card> _cards;

        public Player()
        {
            _cards = new List<Card>();
        }

        public bool WantsOneMoreCard()
        {
            var valueSum = _cards.Sum(c => c.Value);
            Console.WriteLine("Du har disse kortene:");
            foreach (var card in _cards)
            {
                Console.WriteLine(card.Description);
            }

            Console.WriteLine("Total verdi: " + valueSum);
        }
    }
}
