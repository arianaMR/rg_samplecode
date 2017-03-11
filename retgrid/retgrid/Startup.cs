using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(retgrid.Startup))]
namespace retgrid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
