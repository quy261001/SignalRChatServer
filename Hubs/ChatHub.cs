using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public async Task JoinChat(String user, String message)
        {
            await Clients.Others.SendAsync("ReceiveMessage", user, message);
        }
    }
}