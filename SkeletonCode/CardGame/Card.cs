using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonCode.CardGame
{
    class Card : ICard
    {
        public Card(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
