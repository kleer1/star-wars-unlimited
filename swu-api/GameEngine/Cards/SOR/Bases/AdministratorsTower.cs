using SwuApi.GameEngine.Models;

    namespace SwuApi.GameEngine.Cards.SOR.Bases
    {
        internal class AdministratorsTower : Base
        {
            public AdministratorsTower() : base("Administrator's Tower", 30) { }

            public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Cunning };
    
            public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.CloudCity };
        }
    }
    