using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MeuPrimeiroBackend.Startup))]
namespace MeuPrimeiroBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
