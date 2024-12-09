using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Events
    {
        internal class Vanquish : Event
        {
            public Vanquish() : base("Vanquish", 5) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Vigilance };
    
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Tactic };
        }
    }
    