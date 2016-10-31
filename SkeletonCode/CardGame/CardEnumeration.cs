using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace SkeletonCode.CardGame
{
    internal class CardEnumeration : IEnumerator<ICard>
    {
        public ICollection<ICard> Cards;
        private int _position = -1;

        public CardEnumeration(ICollection<ICard> cards)
        {
            Cards = cards;
        }

        public bool MoveNext()
        {
            _position++;
            return (_position < Cards.Count);
        }

        public void Reset()
        {
            _position = -1;
        }

        object IEnumerator.Current => Current;

        public ICard Current
        {
            get
            {
                try
                {
                    return Cards.ElementAt(_position);
                }
                catch (IndexOutOfRangeException)
                { 
                    throw new InvalidOperationException();
                }
            }
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose Not Implemented");
        }
    }
}
