namespace FunnyDevs.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    public sealed class Configuration : DbMigrationsConfiguration<FDDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FDDbContext context)
        {
            //const string roleName = "admin";
            //const string masterAdminUserName = "Xm@ster";

            //var isMasterAdminSeeded = context.Users.Any(u => u.UserName == masterAdminUserName);

            //if (!isMasterAdminSeeded)
            //{
            //    var userManager = new UserManager<User>(new UserStore<User>(context));
            //    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            //    userManager.Create(new User() { UserName = masterAdminUserName, Email = "x@master.com" }, "123456");

            //    roleManager.Create(new IdentityRole() { Name = roleName });

            //    var admin = context.Users.FirstOrDefault(u => u.UserName == masterAdminUserName);

            //    userManager.AddToRole(admin.Id, roleName);
            //}
            if (context.Events.Any())
            {
                return;
            }
            var eventTest = new Event
            {
                Date = DateTime.Now,
                Tittle = "Test",
                Description = "TestDescription",
                Location = "Here",
                GPSLan = "0",
                GPSLong = "0",
                Public = true
            };

            context.Events.Add(eventTest);
            context.SaveChanges();
        }
    }
}
