using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FunnyDevs.Web.Startup))]

namespace FunnyDevs.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}