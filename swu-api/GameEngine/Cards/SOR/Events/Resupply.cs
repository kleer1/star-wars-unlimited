using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Events
{
    internal class Resupply : Event
    {
        public Resupply() : base("Resupply", 3) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Command };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Supply };
    }
}
