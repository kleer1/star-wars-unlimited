using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Bases
{
    internal class CommandCenter : Base
    {
        public CommandCenter() : base("Command Center", 30) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Command };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.DeathStar };
    }
}
