namespace QuizArena.data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using QuizArena.Data;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity;
    using QuizArena.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<QuizArenaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(QuizArenaDbContext context)
        {
            this.AddAdmin(context);
        }

        private void AddAdmin(QuizArenaDbContext context)
        {
            const string roleName = "Admin";

            var userRole = new IdentityRole
            {
                Name = roleName,
                Id = Guid.NewGuid().ToString()
            };

            context.Roles.AddOrUpdate(userRole);

            var hasher = new PasswordHasher();
            var user = new User
            {
                UserName = "Admin",
                PasswordHash = hasher.HashPassword("123456"),
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            user.Roles.Add(new IdentityUserRole
            {
                RoleId = userRole.Id,
                UserId = user.Id
            });

            context.Users.AddOrUpdate(user);
            context.SaveChanges();
        }
    }
}
