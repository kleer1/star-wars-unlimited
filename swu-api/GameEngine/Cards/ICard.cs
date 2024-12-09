using SwuApi.GameEngine.Models;

namespace SwuApi.GameEngine.Cards
{
    internal interface ICard : IHasId, INamed
    {
        IReadOnlyList<Aspect> Aspects { get; }
        IReadOnlySet<Trait> Traits { get; }
    }
}
