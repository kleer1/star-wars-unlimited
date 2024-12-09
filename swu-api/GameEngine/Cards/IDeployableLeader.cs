namespace SwuApi.GameEngine.Cards
{
    internal interface IDeployableLeader : ILeader, IHasStats
    {
        public int DeployCost { get; }
    }
}
