using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppVeiculosAntigos.Web.Startup))]
namespace AppVeiculosAntigos.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
