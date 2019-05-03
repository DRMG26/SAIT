using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SAIT.Startup))]
namespace SAIT
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
