namespace SwuApi.GameEngine.Cards
{
    internal class Event : PlayableCard, IEvent
    {
        public Event(string name, int cost) : base(name, cost)
        {
        }
    }
}
