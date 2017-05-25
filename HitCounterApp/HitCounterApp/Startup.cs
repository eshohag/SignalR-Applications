using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HitCounterApp.Startup))]

namespace HitCounterApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
