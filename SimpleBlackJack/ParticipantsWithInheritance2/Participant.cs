using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlackJack.ParticipantsWithInheritance2
{
    abstract class Participant
    {
        private readonly List<Card> _cards;
        public int ValueSum => _cards.Sum(c => c.Value);

        protected Participant()
        {
            _cards = new List<Card>();
        }

        public bool IsBust()
        {
            return ValueSum > 21;
        }

        public abstract bool WantsOneMoreCard();

        protected void ShowCards()
        {
            Console.WriteLine("Du har disse kortene:");
            foreach (var card in _cards)
            {
                Console.WriteLine(card.Description);
            }

            Console.WriteLine("Total verdi: " + ValueSum);
        }

        public void AddCard(Card card)
        {
            _cards.Add(card);
        }
    }
}
