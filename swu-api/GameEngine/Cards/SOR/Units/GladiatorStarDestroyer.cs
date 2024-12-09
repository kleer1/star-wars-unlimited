using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Units
{
    internal class GladiatorStarDestroyer : SpaceUnit
    {
        public GladiatorStarDestroyer() : base("Gladiator Star Destroyer", 6, 5, 6) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Command, Aspect.Villainy };

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Imperial, Trait.Vehicle, Trait.CapitalShip };
    }
}
