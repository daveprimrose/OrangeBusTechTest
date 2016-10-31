using System;
using System.Collections.Generic;
using System.Linq;

namespace SkeletonCode.CardGame
{
	public class PackOfCardsCreator : IPackOfCardsCreator
	{
	    enum CardType
	    {
	        Heart=0,
            Diamond=1,
            Club=2,
            Spade=3
	    }

        enum CardValue
	    {
            Ace=1, Two=2, Three=3, Four=4, Five=5, Six=6, Seven=7, Eight=8, Nine=9, Ten=10, Jack=11, Queen=12, King=13,
	    };

	    public IPackOfCards Create()
	    {
	        var cards = new List<ICard>();
	        foreach (var type in Enum.GetNames(typeof(CardType)))
	        {
	            cards.AddRange(Enum.GetNames(typeof(CardValue)).Select(value => new Card(value + " of " + type)).Cast<ICard>());
	        }
	        return new PackOfCards(cards);
	    }
	}
}
