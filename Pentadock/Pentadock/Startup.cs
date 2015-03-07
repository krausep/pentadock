using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pentadock.Startup))]
namespace Pentadock
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
