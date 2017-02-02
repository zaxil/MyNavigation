using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyNavigation.Startup))]
namespace MyNavigation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
