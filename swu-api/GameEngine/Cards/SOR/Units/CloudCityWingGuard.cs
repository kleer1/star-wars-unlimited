using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class CloudCityWingGuard : GroundUnit
        {
            public CloudCityWingGuard() : base("Cloud City Wing Guard", 3, 2, 4) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Vigilance };
    
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Fringe, Trait.Trooper };
        }
    }
    