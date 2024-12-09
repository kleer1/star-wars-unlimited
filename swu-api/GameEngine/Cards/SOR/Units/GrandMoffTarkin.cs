using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Units
{
    internal class GrandMoffTarkin : GroundUnit
    {
        public GrandMoffTarkin() : base("Grand Moff Tarkin, title", 4, 2, 3) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Command, Aspect.Villainy };

		public static bool IsUnique => true;

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Imperial, Trait.Official };
    }
}
