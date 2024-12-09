namespace SwuApi.GameEngine.Cards
{
    internal class Unit : PlayableCard, IUnit
    {
        private int _damage = 0;

        public Unit(string name, int cost, int power, int health) : base(name, cost) 
        {
            Power = power;
            Health = health;
        }

        public int Power { get; }

        public int Health { get; }

        public int RemainingHealth { get => Health - _damage; }
    }
}
