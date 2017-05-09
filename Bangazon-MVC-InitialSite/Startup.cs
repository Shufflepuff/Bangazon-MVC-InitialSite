using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bangazon_MVC_InitialSite.Startup))]
namespace Bangazon_MVC_InitialSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
