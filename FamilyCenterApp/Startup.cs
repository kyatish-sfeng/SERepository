using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FamilyCenterApp.Startup))]
namespace FamilyCenterApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
