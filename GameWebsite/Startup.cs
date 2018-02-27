using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameWebsite.Startup))]
namespace GameWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
