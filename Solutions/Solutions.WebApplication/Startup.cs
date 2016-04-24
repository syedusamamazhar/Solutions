using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Solutions.WebApplication.Startup))]
namespace Solutions.WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
