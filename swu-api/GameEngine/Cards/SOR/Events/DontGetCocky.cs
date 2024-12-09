using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Events
{
    internal class DontGetCocky : Event
    {
        public DontGetCocky() : base("Don't Get Cocky", 4) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Cunning };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Gambit };
    }
}
