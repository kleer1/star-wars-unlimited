using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards
{
    internal class Card : ICard
    {
        public Card(string name)
        {
            Id = new Guid();
            Name = name;
        }

        public Guid Id { get; }

        public string Name { get; }

        public IReadOnlyList<Aspect> Aspects => throw new NotImplementedException();

        public IReadOnlySet<Trait> Traits => throw new NotImplementedException();
    }
}
