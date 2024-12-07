namespace SwuApi.Server.Models
{
    public class SwdbItem
    {
        public string Id { get; set; } = "";
        public int Count { get; set; }
    }

    public class SwdbMetadata
    {
        public string Name { get; set; } = "";
        public string Author { get; set; } = "";
    }

    public class SwdbDeck
    {
        public SwdbMetadata Metadata { get; set; } = new SwdbMetadata();
        public SwdbItem Leader { get; set; } = new SwdbItem();
        public SwdbItem SecondLeader { get; set; } = new SwdbItem();
        public SwdbItem Base { get; set; } = new SwdbItem();
        public List<SwdbItem> Deck { get; set; } = [];
    }
}
