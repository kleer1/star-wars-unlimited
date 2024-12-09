using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Units
{
    internal class DeathStarStormtrooper : GroundUnit
    {
        public DeathStarStormtrooper() : base("Death Star Stormtrooper", 1, 3, 1) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Aggression, Aspect.Villainy };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Imperial, Trait.Trooper };
    }
}
