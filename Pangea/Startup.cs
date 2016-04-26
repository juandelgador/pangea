using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pangea.Startup))]
namespace Pangea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
