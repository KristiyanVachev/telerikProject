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
    using System.Collections.Generic;

    //made public dut to error CS0122
    internal sealed class Configuration : DbMigrationsConfiguration<QuizArenaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(QuizArenaDbContext context)
        {

           context.Categories.AddOrUpdate(
           c => c.Id,
           new Category { Name = "Software" },
           new Category { Name = "Hardware" }
           );


            //if (context.Users.Any())
            //{
            //    return;
            //}

            //this.AddAdmin(context);

            //Just some test questions
            //var questions = new List<Question>
            //{
            //new Question{Id=1,QuestionText="What is ROM",AnswerRight="Read Only Memory", AnswerWrong1="Gipsy", AnswerWrong2="Stamat",AnswerWrong3="Other"},
            //new Question{Id=2,QuestionText="What is RAM",AnswerRight="Random Access Memory", AnswerWrong1="Not", AnswerWrong2="Anything",AnswerWrong3="Else"},
            //new Question{Id=3,QuestionText="Jon's mother?",AnswerRight="Lyanna", AnswerWrong1="Wendy", AnswerWrong2="Bessy",AnswerWrong3="Fishermans wife"},
            //new Question{Id=4,QuestionText="Azor Ahai?",AnswerRight="Jon Snow", AnswerWrong1="Stannis", AnswerWrong2="Daenerys",AnswerWrong3="Tyrion"}
            //};


            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.Id,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );

        
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
        }
    }
}
