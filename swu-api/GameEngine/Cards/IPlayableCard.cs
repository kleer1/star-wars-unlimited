namespace SwuApi.GameEngine.Cards
{
    internal interface IPlayableCard : ICard, IIsUnique
    {
        int PlayCost { get; }
    }
}
