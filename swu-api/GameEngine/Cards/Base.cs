using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards
{
    internal class Base : Card, IBase
    {
        public Base(string name, int health) : base(name)
        {
            Health = health;
        }

        public int Health { get; }
    }
}
