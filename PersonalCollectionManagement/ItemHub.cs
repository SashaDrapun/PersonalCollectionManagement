using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace SignalRApp
{
    public class ItemHub : Hub
    {
        public async Task Send(string message, string userNickname, int idItem, DateTime dateTime)
        {
            await Clients.All.SendAsync("Send", message, userNickname, idItem, dateTime.ToString());
        }

        public async Task SendLike(int idItem, int CountLikes)
        {
            await Clients.All.SendAsync("SendLike", idItem, CountLikes);
        }
    }
}