namespace SwuApi.GameEngine.Models
{
    internal interface IPlayer : IHasId
    {
        ICard Base { get; }
        ICard Leader { get; }
        List<ICard> Deck { get; }
        List<ICard> Hand { get; }
        List<ICard> Discard { get; }
        List<ICard> Resources { get; }
        List<ICard> Ground { get; }
        List<ICard> Space { get; }
    }
}
