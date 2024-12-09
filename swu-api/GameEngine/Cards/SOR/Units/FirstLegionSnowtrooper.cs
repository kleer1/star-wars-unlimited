using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Units
{
    internal class FirstLegionSnowtrooper : GroundUnit
    {
        public FirstLegionSnowtrooper() : base("First Legion Snowtrooper", 2, 2, 3) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Aggression, Aspect.Villainy };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Imperial, Trait.Trooper };
    }
}
