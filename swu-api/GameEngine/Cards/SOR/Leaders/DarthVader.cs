using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Leaders
{
    internal class DarthVader : DeployableLeader
    {
        public DarthVader() : base("Darth Vader, title", 7, 5, 8) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Aggression, Aspect.Villainy };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Force, Trait.Imperial, Trait.Sith };
    }
}
