using System.Text.Json;
using Microsoft.AspNetCore.SignalR;

namespace TwaddleApp;

public class ChatHub : Hub
{
    public async Task SendMessage(ChatMessage message)
    {
        // TODO save to a database

        await Clients.Group(message.ChatId).SendAsync("ReceiveMessage", message);
    }
}

public class ChatMessage
{
    public string ChatId { get; init; }
    public string UserId { get; init; }
    public string Message { get; init; }
}