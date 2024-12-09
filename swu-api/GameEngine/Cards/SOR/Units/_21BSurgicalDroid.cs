using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class _21BSurgicalDroid : GroundUnit
        {
            public _21BSurgicalDroid() : base("2-1B Surgical Droid", 1, 1, 3) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Vigilance };
    
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Droid };
        }
    }
    