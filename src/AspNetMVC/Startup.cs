using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetMVC.Startup))]
namespace AspNetMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
