using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class RestoredARC170 : SpaceUnit
        {
            public RestoredARC170() : base("Restored ARC-170", 2, 2, 3) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Vigilance, Aspect.Heroism };
    
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Rebel, Trait.Vehicle, Trait.Fighter };
        }
    }
    