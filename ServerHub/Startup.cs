using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServerHub.Startup))]
namespace ServerHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
