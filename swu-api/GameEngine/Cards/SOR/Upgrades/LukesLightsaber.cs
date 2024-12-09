using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Upgrades
    {
        internal class LukesLightsaber : Upgrade
        {
            public LukesLightsaber() : base("Luke's Lightsaber", 2, 3, 1) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Vigilance, Aspect.Heroism };
    
		public static bool IsUnique => true;

            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Item, Trait.Weapon, Trait.Lightsaber };
        }
    }
    