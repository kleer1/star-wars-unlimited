using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class RogueOperative : GroundUnit
        {
            public RogueOperative() : base("Rogue Operative", 3, 2, 4) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Cunning, Aspect.Heroism };
    
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Rebel, Trait.Trooper };
        }
    }
    