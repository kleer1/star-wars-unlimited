using Moq;
using Moq.Protected;
using Microsoft.Extensions.Logging;
using Server.Tests.Attributes;
using SwuApi.Server.Models;

namespace SwuApi.Server.Services.Tests
{
    public class SwdbServiceTests
    {
        private Mock<ILogger<SwdbService>> _mockLogger;
        private Mock<IHttpClientFactory> _mockHttpClientFactory;
        private Mock<HttpMessageHandler> _mockMessageHandler;
        private HttpClient _httpClient;
        private readonly SwdbService _swdbService;

        public SwdbServiceTests()
        {
            _mockLogger = new Mock<ILogger<SwdbService>>();
            _mockHttpClientFactory = new Mock<IHttpClientFactory>();
            _swdbService = new SwdbService(_mockHttpClientFactory.Object, _mockLogger.Object);

            _mockMessageHandler = new Mock<HttpMessageHandler>();
            _httpClient = new HttpClient(_mockMessageHandler.Object);
            _mockHttpClientFactory.Setup(x => x.CreateClient(It.IsAny<string>())).Returns(_httpClient);
        }

        [Theory]
        [FileData("Resources/valid_decklist.txt")]
        public async Task GetDeckListAsyncTest(string text)
        {
            _mockMessageHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(() =>
                {
                    HttpResponseMessage response = new HttpResponseMessage
                    {
                        StatusCode = System.Net.HttpStatusCode.OK,
                        Content = new StringContent(text)
                    };
                    return response;
                });

            IReadOnlyDictionary<string, int> result = await _swdbService.GetDeckListAsync("https://swudb.com/deck/validdeck");
            Assert.NotNull(result);

            int count = Assert.Contains("TWI_1", result);
            Assert.Equal(1, count);

            count = Assert.Contains("TWI_2", result);
            Assert.Equal(1, count);

            count = Assert.Contains("SOR_1", result);
            Assert.Equal(3, count);

            count = Assert.Contains("SOR_2", result);
            Assert.Equal(2, count);

            count = Assert.Contains("SHD_3", result);
            Assert.Equal(1, count);
        }
    }
}