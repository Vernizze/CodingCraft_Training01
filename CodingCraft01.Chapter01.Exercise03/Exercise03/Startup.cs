using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exercise03.Startup))]
namespace Exercise03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
