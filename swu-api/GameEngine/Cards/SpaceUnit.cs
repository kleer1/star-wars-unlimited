namespace SwuApi.GameEngine.Cards
{
    internal class SpaceUnit : Unit, ISpaceUnit
    {
        public SpaceUnit(string name, int cost, int power, int health) : base(name, cost, power, health)
        {
        }
    }
}
