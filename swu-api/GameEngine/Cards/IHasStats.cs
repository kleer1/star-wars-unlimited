namespace SwuApi.GameEngine.Cards
{
    internal interface IHasStats
    {
        int Power { get; }
        int Health { get; }
        int RemainingHealth { get; }
    }
}
