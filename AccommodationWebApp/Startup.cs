using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AccommodationWebApp.Startup))]
namespace AccommodationWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
