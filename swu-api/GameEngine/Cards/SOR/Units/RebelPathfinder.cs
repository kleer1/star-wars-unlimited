using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class RebelPathfinder : GroundUnit
        {
            public RebelPathfinder() : base("Rebel Pathfinder", 2, 2, 3) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Heroism };
    
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Rebel, Trait.Trooper };
        }
    }
    