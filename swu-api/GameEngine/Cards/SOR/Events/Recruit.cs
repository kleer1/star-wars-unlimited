using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Events
{
    internal class Recruit : Event
    {
        public Recruit() : base("Recruit", 1) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Command };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Supply };
    }
}
