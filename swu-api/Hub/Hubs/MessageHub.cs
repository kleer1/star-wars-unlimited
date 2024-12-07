using Microsoft.AspNetCore.SignalR;
using SwuApi.Server.Models;

namespace SwuApi.Server.Hubs
{

    public class MessageHub : Hub
    {
        private static readonly List<UserMessage> MessageHistory = new List<UserMessage>();

        private readonly ILogger<MessageHub> _logger;

        public MessageHub(ILogger<MessageHub> logger)
        {
            _logger = logger;
        }

        public async Task PostMessage(string content)
        {
            var senderId = Context.ConnectionId;
            var userMessage = new UserMessage
            {
                Sender = senderId,
                Content = content,
                SentTime = DateTime.UtcNow
            };
            MessageHistory.Add(userMessage);
            await Clients.Others.SendAsync("ReceiveMessage", senderId, content, userMessage.SentTime);
            _logger.LogInformation("Message Posted {UserMessage}", userMessage);
        }
        public async Task RetrieveMessageHistory() =>
            await Clients.Caller.SendAsync("MessageHistory", MessageHistory);
    }
}
