using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exercise04.Startup))]
namespace Exercise04
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
