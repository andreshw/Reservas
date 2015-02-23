using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Reservas.Web.Startup))]
namespace Reservas.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
