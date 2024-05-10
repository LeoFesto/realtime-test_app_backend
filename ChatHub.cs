using Microsoft.AspNetCore.SignalR;

namespace realtime_on_production_test
{
    public class ChatHub : Hub
    {
        public async Task Connect(string name)
        {
            await this.Clients.All.SendAsync("ReceiveConnect",name);
        }

        public async Task SendMessage(MessageData messageData)
        {
            await this.Clients.All.SendAsync("ReceiveMessage", messageData);
        }

    }

    public record class MessageData(string name, string message);
}
