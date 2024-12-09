using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class WingLeader : SpaceUnit
        {
            public WingLeader() : base("Wing Leader", 3, 2, 1) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Heroism };
    
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Rebel, Trait.Vehicle, Trait.Fighter };
        }
    }
    