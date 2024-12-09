using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Units
{
    internal class SuperlaserTechnician : GroundUnit
    {
        public SuperlaserTechnician() : base("Superlaser Technician", 3, 2, 1) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Command, Aspect.Villainy };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Imperial };
    }
}
