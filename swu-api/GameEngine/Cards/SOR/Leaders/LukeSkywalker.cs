using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Leaders
{
    internal class LukeSkywalker : DeployableLeader
    {
        public LukeSkywalker() : base("Luke Skywalker, title", 6, 4, 7) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Vigilance, Aspect.Heroism };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Force, Trait.Rebel };
    }
}
