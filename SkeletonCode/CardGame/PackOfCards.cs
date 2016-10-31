using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SkeletonCode.CardGame
{
    class PackOfCards : IPackOfCards
    {
        private ICollection<ICard> _cards;

        public int Count => _cards.Count;

        public PackOfCards(ICollection<ICard> cards)
        {
            _cards = cards;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            return new CardEnumeration(_cards);
        }

        public void Shuffle()
        {
            var rnd = new Random();
            var currentDeck = _cards;
            var shuffledDeck = new List<ICard>();
            for (var i = _cards.Count - 1; i >= 0; i--)
            {
                var randomNumber = rnd.Next(i + 1);
                var randomCard = currentDeck.ElementAt(randomNumber);
                currentDeck.Remove(randomCard);
                shuffledDeck.Add(randomCard);
            }
            _cards = shuffledDeck;
        }

        public ICard TakeCardFromTopOfPack()
        {
            var topCard = _cards.ElementAt(_cards.Count-1);
            _cards.Remove(topCard);
            return topCard;
        }
    }
}
