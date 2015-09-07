using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TapDemoMVC.Startup))]
namespace TapDemoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
