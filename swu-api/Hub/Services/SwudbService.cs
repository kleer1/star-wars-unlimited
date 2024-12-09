
using SwuApi.Server.Exceptions;
using SwuApi.Server.Models;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace SwuApi.Server.Services
{
    public class SwudbService : ISwudbService
    {
        private static readonly Regex urlRegex = new Regex(@"https://swudb.com/deck/[a-zA-Z]+");
        private static readonly Regex deckListRegex = new Regex(@"(?<=JSON\.stringify\()(.*)(?=, null, 2\))", RegexOptions.Singleline);

        private IHttpClientFactory _httpClientFactory;
        private ILogger<SwudbService> _logger;
        private readonly JsonSerializerOptions _serializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public SwudbService(IHttpClientFactory client, ILogger<SwudbService> logger) 
        { 
            _httpClientFactory = client;
            _logger = logger;
        }

        public async Task<IReadOnlyDictionary<string, int>> GetDeckListAsync(string url)
        {
            string deckListString = await GetDeckListStringAsync(url);
            deckListString = Regex.Replace(deckListString, @"\r\n?|\n", " ");
            SwdbDeck deck = JsonSerializer.Deserialize<SwdbDeck>(deckListString, _serializerOptions) ?? 
                throw new SwudbDeckException("Deck JSON could not be converted to a deck object.");
            return ConvertDeckToDictionary(deck);
        }

        private async Task<string> GetDeckListStringAsync(string url)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(url, nameof(url));
            if (!urlRegex.IsMatch(url))
            {
                _logger.LogWarning("Url is not a valid SWDB deck link: {Url}", url);
                throw new ArgumentException(url, nameof(url));
            }
            HttpClient client = _httpClientFactory.CreateClient();
            string response = await client.GetStringAsync(new Uri(url));
            Match deckListMatch = deckListRegex.Match(response);
            if (!deckListMatch.Success)
            {
                SwudbDeckException.ThrowNoDeckFound();
            }
            return deckListMatch.Value;
        }

        private IReadOnlyDictionary<string, int> ConvertDeckToDictionary(SwdbDeck deck)
        {
            Dictionary<string, int> mapping = new Dictionary<string, int>();
            mapping.Add(deck.Leader.Id, deck.Leader.Count);
            mapping.Add(deck.Base.Id, deck.Base.Count);
            foreach (SwudbItem item in deck.Deck)
            {
                mapping.Add(item.Id, item.Count);
            }
            return mapping;
        }
    }
}
