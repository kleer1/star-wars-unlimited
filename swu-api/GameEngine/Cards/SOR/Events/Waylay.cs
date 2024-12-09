using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Events
    {
        internal class Waylay : Event
        {
            public Waylay() : base("Waylay", 3) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Cunning };
    
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Trick };
        }
    }
    