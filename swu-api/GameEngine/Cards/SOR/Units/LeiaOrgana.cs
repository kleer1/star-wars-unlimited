using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class LeiaOrgana : GroundUnit
        {
            public LeiaOrgana() : base("Leia Organa, title", 2, 2, 2) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Cunning, Aspect.Heroism };
    
		public static bool IsUnique => true;

            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Rebel, Trait.Official };
        }
    }
    