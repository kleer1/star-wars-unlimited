using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class FleetLieutenant : GroundUnit
        {
            public FleetLieutenant() : base("Fleet Lieutenant", 3, 3, 3) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Heroism };
    
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Rebel, Trait.Trooper };
        }
    }
    