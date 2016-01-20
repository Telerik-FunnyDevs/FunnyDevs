using FunnyDevs.Data.Migrations;
using FunnyDevs.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace FunnyDevs.Data
{
    public class DbContext : IdentityDbContext<User>, IDbContext
    {
        public DbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DbContext, Configuration>());
        }

        public static DbContext Create()
        {
            return new DbContext();
        }
    }
}
