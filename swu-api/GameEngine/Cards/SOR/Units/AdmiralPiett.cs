using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Units
{
    internal class AdmiralPiett : GroundUnit
    {
        public AdmiralPiett() : base("Admiral Piett, title", 2, 1, 4) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Command, Aspect.Villainy };

		public static bool IsUnique => true;

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Imperial, Trait.Official };
    }
}
