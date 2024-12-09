using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class ConsularSecurityForce : GroundUnit
        {
            public ConsularSecurityForce() : base("Consular Security Force", 4, 3, 7) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Vigilance, Aspect.Heroism };
    
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Rebel, Trait.Trooper };
        }
    }
    