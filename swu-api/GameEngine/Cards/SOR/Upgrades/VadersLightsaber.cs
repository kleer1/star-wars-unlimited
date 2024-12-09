using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Upgrades
{
    internal class VadersLightsaber : Upgrade
    {
        public VadersLightsaber() : base("Vader's Lightsaber", 2, 3, 1) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Aggression, Aspect.Villainy };

		public static bool IsUnique => true;

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Item, Trait.Weapon, Trait.Lightsaber };
    }
}
