using System.Reflection.Metadata.Ecma335;

namespace SwuApi.GameEngine.Cards
{
    internal class Leader : Card, ILeader
    {
        public Leader(string name) : base(name)
        {
        }

        public bool IsUnique => true;
    }
}
