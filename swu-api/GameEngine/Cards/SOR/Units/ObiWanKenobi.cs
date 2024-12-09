using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class ObiWanKenobi : GroundUnit
        {
            public ObiWanKenobi() : base("Obi-Wan Kenobi, title", 6, 4, 6) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Vigilance, Aspect.Heroism };
    
		public static bool IsUnique => true;

            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Force, Trait.Jedi };
        }
    }
    