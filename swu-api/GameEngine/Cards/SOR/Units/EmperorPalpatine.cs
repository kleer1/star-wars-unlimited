using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards.SOR.Units
{
    internal class EmperorPalpatine : GroundUnit
    {
        public EmperorPalpatine() : base("Emperor Palpatine, title", 8, 6, 6) { }

        public static new IReadOnlyList<Aspect> Aspects => new List<Aspect> { Aspect.Aggression, Aspect.Villainy };

		public static bool IsUnique => true;

        public new static IReadOnlySet<Trait> Traits => new HashSet<Trait>() { Trait.Force, Trait.Imperial, Trait.Sith, Trait.Official };
    }
}
