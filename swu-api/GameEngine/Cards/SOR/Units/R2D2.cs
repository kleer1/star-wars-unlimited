using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class R2D2 : GroundUnit
        {
            public R2D2() : base("R2-D2, title", 1, 1, 4) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Heroism };
    
		public static bool IsUnique => true;

            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Rebel, Trait.Droid };
        }
    }
    