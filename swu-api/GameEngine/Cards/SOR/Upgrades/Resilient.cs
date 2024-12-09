using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Upgrades
    {
        internal class Resilient : Upgrade
        {
            public Resilient() : base("Resilient", 1, 0, 3) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Vigilance };
    
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Innate };
        }
    }
    