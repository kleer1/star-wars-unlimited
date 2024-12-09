using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class C3PO : GroundUnit
        {
            public C3PO() : base("C-3PO, title", 2, 1, 4) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Heroism };
    
		public static bool IsUnique => true;

            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Rebel, Trait.Droid };
        }
    }
    