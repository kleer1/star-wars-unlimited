namespace SwuApi.Server.Models
{
    public class SwudbItem
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
        public SwudbItem Leader { get; set; } = new SwudbItem();
        public SwudbItem SecondLeader { get; set; } = new SwudbItem();
        public SwudbItem Base { get; set; } = new SwudbItem();
        public List<SwudbItem> Deck { get; set; } = [];
    }
}
