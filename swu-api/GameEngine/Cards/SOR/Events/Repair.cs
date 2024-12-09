using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Events
    {
        internal class Repair : Event
        {
            public Repair() : base("Repair", 1) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Vigilance };
    
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Supply };
        }
    }
    