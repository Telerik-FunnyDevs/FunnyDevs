using Microsoft.Owin;
using Owin;
using System.Configuration;
using System.Data.Entity;

[assembly: OwinStartupAttribute(typeof(FunnyDevs.Web.Startup))]
namespace FunnyDevs.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
           // Database.SetInitializer(new MigrateDatabaseToLatestVersion<DbContext, Configuration>());
        }
    }
}
