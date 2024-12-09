using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Units
    {
        internal class SystemPatrolCraft : SpaceUnit
        {
            public SystemPatrolCraft() : base("System Patrol Craft", 4, 3, 4) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Vigilance };
    
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Vehicle, Trait.Fighter };
        }
    }
    