using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eDrago.Startup))]
namespace eDrago
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
