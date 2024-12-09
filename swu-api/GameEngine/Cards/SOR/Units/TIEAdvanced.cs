using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Units
{
    internal class TIEAdvanced : SpaceUnit
    {
        public TIEAdvanced() : base("TIE Advanced", 4, 3, 2) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Villainy };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Imperial, Trait.Fighter, Trait.Vehicle };
    }
}