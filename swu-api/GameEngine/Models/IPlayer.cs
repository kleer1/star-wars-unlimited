using SwuApi.GameEngine.Cards;

namespace SwuApi.GameEngine.Models
{
    internal interface IPlayer : IHasId
    {
        IBase Base { get; }
        ILeader Leader { get; }
        List<IPlayableCard> Deck { get; }
        List<IPlayableCard> Hand { get; }
        List<IPlayableCard> Discard { get; }
        List<IPlayableCard> Resources { get; }
        List<IGroundUnit> Ground { get; }
        List<ISpaceUnit> Space { get; }
    }
}
