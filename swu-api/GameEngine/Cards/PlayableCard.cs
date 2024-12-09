namespace SwuApi.GameEngine.Cards
{
    internal class PlayableCard : Card, IPlayableCard
    {
        public PlayableCard(string name, int cost) : base(name)
        {
            PlayCost = cost;
        }

        public int PlayCost { get; }
    }
}
