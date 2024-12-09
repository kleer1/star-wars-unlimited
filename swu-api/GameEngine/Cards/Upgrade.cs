namespace SwuApi.GameEngine.Cards
{
    internal class Upgrade : PlayableCard, IUpgrade
    {
        public Upgrade(string name, int cost, int bonusPower, int bonusHp) : base(name, cost)
        {
            BonusPower = bonusPower;
            BonusHP = bonusHp;
        }

        public int BonusPower { get; }

        public int BonusHP { get; }
    }
}
