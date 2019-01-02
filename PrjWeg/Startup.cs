using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrjWeg.Startup))]
namespace PrjWeg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
