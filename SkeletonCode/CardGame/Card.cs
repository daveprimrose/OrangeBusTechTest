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
