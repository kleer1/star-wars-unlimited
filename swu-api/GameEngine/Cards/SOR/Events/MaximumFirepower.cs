using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Events
{
    internal class MaximumFirepower : Event
    {
        public MaximumFirepower() : base("Maximum Firepower", 4) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Villainy };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Imperial, Trait.Tactic };
    }
}
