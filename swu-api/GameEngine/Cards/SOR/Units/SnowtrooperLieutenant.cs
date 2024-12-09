using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Units
{
    internal class SnowtrooperLieutenant : GroundUnit
    {
        public SnowtrooperLieutenant() : base("Snowtrooper Lieutenant", 2, 2, 2) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Villainy };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Imperial, Trait.Trooper };
    }
}
