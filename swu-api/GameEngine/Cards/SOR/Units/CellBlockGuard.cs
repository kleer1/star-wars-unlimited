using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Units
{
    internal class CellBlockGuard : GroundUnit
    {
        public CellBlockGuard() : base("Cell Block Guard", 3, 3, 3) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Villainy };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Imperial, Trait.Trooper };
    }
}
