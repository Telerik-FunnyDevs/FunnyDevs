using FunnyDevs.Data.Migrations;
using FunnyDevs.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace FunnyDevs.Data
{
    public class FDDbContext : IdentityDbContext<User>, IFDDbContext
    {
        public FDDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Event> Events { get; set; }
        public static FDDbContext Create()
        {
            return new FDDbContext();
        }
    }
}
