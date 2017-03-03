using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Mvc5Angular2SignalRWithWebpack.Startup))]
namespace Mvc5Angular2SignalRWithWebpack
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			// Any connection or hub wire up and configuration should go here
			app.MapSignalR();
		}
	}
}