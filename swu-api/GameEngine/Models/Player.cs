
namespace SwuApi.GameEngine.Models
{
    internal class Player : IPlayer
    {
        public Player(ICard baseCard, ICard leader)
        {
            Id = new Guid();
            Base = baseCard;
            Leader = leader;
            Deck = [];
            Hand = [];
            Discard = [];
            Resources = [];
            Ground = [];
            Space = [];
        }

        public Guid Id { get; }

        public ICard Base { get; private set; }

        public ICard Leader { get; private set; }

        public List<ICard> Deck { get; private set; }

        public List<ICard> Hand { get; private set; }

        public List<ICard> Discard { get; private set; }

        public List<ICard> Resources { get; private set; }

        public List<ICard> Ground { get; private set; }

        public List<ICard> Space { get; private set; }
    }
}
