
using SwuApi.GameEngine.Cards;
using SwuApi.GameEngine.Utils;
using static SwuApi.GameEngine.Utils.ListExtension;

namespace SwuApi.GameEngine.Models
{
    internal class Player : IPlayer
    {
        public Player(IReadOnlyDictionary<string, int> deck)
        {
            Id = new Guid();
            Deck = [];
            Hand = [];
            Discard = [];
            Resources = [];
            Ground = [];
            Space = [];

            foreach (KeyValuePair<string, int> pair in deck)
            {
                for (int i = 0; i < pair.Value; i++)
                {
                    ICard card = SwudbMappingUtil.GetCardFromSetNumber(pair.Key);
                    if (card is ILeader)
                    {
                        Leader = (ILeader)card;
                    }
                    else if (card is IBase)
                    {
                        Base = (IBase)card;
                    }
                    else if (card is IPlayableCard)
                    {
                        Deck.Add((IPlayableCard)card);
                    }
                }
            }
            Deck.Shuffle();
        }

        public Guid Id { get; }

        public IBase Base { get; }

        public ILeader Leader { get; }

        public List<IPlayableCard> Deck { get; }

        public List<IPlayableCard> Hand { get; }

        public List<IPlayableCard> Discard { get; }

        public List<IPlayableCard> Resources { get; }

        public List<IGroundUnit> Ground { get; }

        public List<ISpaceUnit> Space { get; }
    }
}
