using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Units
{
    internal class AdmiralMotti : GroundUnit
    {
        public AdmiralMotti() : base("Admiral Motti, title", 2, 1, 1) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Villainy };

		public static bool IsUnique => true;

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Imperial, Trait.Official };
    }
}
