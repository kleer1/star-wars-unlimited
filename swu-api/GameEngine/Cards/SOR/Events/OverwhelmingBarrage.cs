using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Events
{
    internal class OverwhelmingBarrage : Event
    {
        public OverwhelmingBarrage() : base("Overwhelming Barrage", 5) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Command, Aspect.Villainy };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Tactic };
    }
}
