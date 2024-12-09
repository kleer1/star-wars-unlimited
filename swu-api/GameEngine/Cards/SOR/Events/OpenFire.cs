using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Events
{
    internal class OpenFire : Event
    {
        public OpenFire() : base("Open Fire", 3) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Aggression };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Tactic };
    }
}
