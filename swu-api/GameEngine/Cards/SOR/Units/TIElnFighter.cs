using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Units
{
    internal class TIElnFighter : SpaceUnit
    {
        public TIElnFighter() : base("TIE/ln Fighter", 1, 2, 1) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Villainy };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Imperial, Trait.Vehicle, Trait.Fighter };
    }
}
