using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class AuzituckLiberatorGunship : SpaceUnit
        {
            public AuzituckLiberatorGunship() : base("Auzituck Liberator Gunship", 4, 3, 4) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Cunning, Aspect.Heroism };
    
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Vehicle, Trait.Fighter };
        }
    }
    