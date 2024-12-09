using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Units
{
    internal class ImperialInterceptor : SpaceUnit
    {
        public ImperialInterceptor() : base("Imperial Interceptor", 4, 3, 2) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Aggression, Aspect.Villainy };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Imperial, Trait.Vehicle, Trait.Fighter };
    }
}
