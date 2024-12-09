namespace SwuApi.GameEngine.Cards
{
    internal class GroundUnit : Unit, IGroundUnit
    {
        public GroundUnit(string name, int cost, int power, int health) : base(name, cost, power, health)
        {
        }
    }
}
