using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PusherTest.Startup))]
namespace PusherTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
