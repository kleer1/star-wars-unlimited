using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class Snowspeeder : GroundUnit
        {
            public Snowspeeder() : base("Snowspeeder", 5, 3, 6) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Heroism };
    
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Rebel, Trait.Vehicle, Trait.Speeder };
        }
    }
    