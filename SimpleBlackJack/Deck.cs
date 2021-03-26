using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleBlackJack
{
    class Deck
    {
        private readonly Stack<Card> _cards;
        private static readonly Random _random = new Random();

        public Deck()
        {
            var cards = Enumerable
                .Range(0, 52)
                .Select(i => new Card(1+(i % 13), (Suit)(i / 13)))
                .ToArray();
            Shuffle(cards);
            _cards = new Stack<Card>(cards);
        }

        public Card Draw()
        {
            return _cards.Pop();
        }

        private static void Shuffle(Card[] cards)
        {
            var cardsCount = cards.Length;
            for (var i = 0; i < cardsCount; i++)
            {
                var deltaIndex = _random.Next(1, cardsCount);
                var otherIndex = (i + deltaIndex) % cardsCount;
                SwapCard(cards, i, otherIndex);
            }
        }

        private static void SwapCard(Card[] cards, int indexA, int indexB)
        {
            var tmp = cards[indexA];
            cards[indexA] = cards[indexB];
            cards[indexB] = tmp;
        }
    }
}
