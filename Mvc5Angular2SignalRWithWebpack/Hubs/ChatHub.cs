using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc5Angular2SignalRWithWebpack.Hubs
{
	public class ChatHub : Hub
	{
		public void Send(string name, string message)
		{
			// Call the addNewMessageToPage method to update clients.
			Clients.All.addNewMessageToPage(name, message);
		}
	}
}