namespace WebBug.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebBug.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebBug.Data.WebBugDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebBug.Data.WebBugDbContext context)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new WebBugDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new WebBugDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "Giang",
                Email = "phanvangiang1998@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "Phan Van giang"

            };

            manager.Create(user, "123654$");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("phanvangiang1998@gmail.com");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
    }
}
