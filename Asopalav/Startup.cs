using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asopalav.Startup))]
namespace Asopalav
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
