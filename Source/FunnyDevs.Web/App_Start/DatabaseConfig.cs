using FunnyDevs.Data;
using FunnyDevs.Data.Migrations;
using System.Data.Entity;

namespace FunnyDevs.Web.App_Start
{
    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FDDbContext, Configuration>());
        }
    }
}
