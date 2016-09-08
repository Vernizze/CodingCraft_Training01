using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exercise05.Startup))]
namespace Exercise05
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
