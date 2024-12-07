using Microsoft.AspNetCore.SignalR;

namespace SwuApi.Server.Hubs
{
    public class GameHub : Hub
    {
        private readonly ILogger<GameHub> _logger;

        public GameHub(ILogger<GameHub> logger)
        {
            _logger = logger;
        }


    }
}
