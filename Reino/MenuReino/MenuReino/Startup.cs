using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MenuReino.Startup))]
namespace MenuReino
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
