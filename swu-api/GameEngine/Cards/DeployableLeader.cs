
namespace SwuApi.GameEngine.Cards
{
    internal class DeployableLeader : Leader, IDeployableLeader
    {
        private int _damage = 0;

        public DeployableLeader(string name, int deployCost, int power, int health) : base(name)
        {
            DeployCost = deployCost;
            Power = power;
            Health = health;
        }

        public int DeployCost { get; }

        public int Power { get; }

        public int Health { get; }

        public int RemainingHealth { get => Health - _damage; }
    }
}
