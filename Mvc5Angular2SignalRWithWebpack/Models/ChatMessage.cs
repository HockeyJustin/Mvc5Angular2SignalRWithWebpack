using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc5Angular2SignalRWithWebpack.Models
{
	public class ChatMessage
	{
		public string Message { get; set; }
		public DateTime Sent { get; set; }
	}
}