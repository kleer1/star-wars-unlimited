namespace SwuApi.GameEngine.Cards
{
    internal interface IUpgrade : IPlayableCard
    {
        int BonusPower { get; }
        int BonusHP { get; }
    }
}
