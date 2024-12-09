using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Units
{
    internal class AdmiralOzzel : GroundUnit
    {
        public AdmiralOzzel() : base("Admiral Ozzel, Overconfident", 2, 2, 3) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Aggression, Aspect.Villainy };

		public static bool IsUnique => true;

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Imperial, Trait.Official };
    }
}
