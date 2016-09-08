using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exercise02.Startup))]
namespace Exercise02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
