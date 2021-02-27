using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElectricShopWebApp.Startup))]
namespace ElectricShopWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
