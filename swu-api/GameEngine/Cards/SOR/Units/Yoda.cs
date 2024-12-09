using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class Yoda : GroundUnit
        {
            public Yoda() : base("Yoda, title", 3, 2, 4) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Vigilance, Aspect.Heroism };
    
		public static bool IsUnique => true;

            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Force, Trait.Jedi };
        }
    }
    