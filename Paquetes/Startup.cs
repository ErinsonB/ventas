using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Paquetes.Startup))]
namespace Paquetes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
