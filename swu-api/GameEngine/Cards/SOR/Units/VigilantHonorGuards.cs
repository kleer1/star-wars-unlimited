using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class VigilantHonorGuards : GroundUnit
        {
            public VigilantHonorGuards() : base("Vigilant Honor Guards", 5, 4, 6) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Vigilance, Aspect.Heroism };
    
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Rebel };
        }
    }
    