using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleBlackJack.ParticipantsWithInterface
{
    class Player : IBlackJackParticipant
    {
        private readonly List<Card> _cards;
        public int ValueSum => _cards.Sum(c => c.Value);

        public Player()
        {
            _cards = new List<Card>();
        }

        public bool IsBust()
        {
            return ValueSum > 21;
        }

        public bool WantsOneMoreCard()
        {
            ShowCards();
            Console.Write("Vil du ha et kort til (j/n)? ");
            var answer = Console.ReadLine();
            return answer?.ToLower() == "j";
        }

        private void ShowCards()
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
