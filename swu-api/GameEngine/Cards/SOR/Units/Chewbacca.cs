using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class Chewbacca : GroundUnit
        {
            public Chewbacca() : base("Chewbacca, title", 5, 3, 6) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Cunning, Aspect.Heroism };
    
		public static bool IsUnique => true;

            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Underworld, Trait.Wookiee };
        }
    }
    