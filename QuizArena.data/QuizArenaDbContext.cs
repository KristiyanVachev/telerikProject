using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizArena.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using QuizArena.data.Migrations;
using System.Data.Entity;

namespace QuizArena.Data
{
    public class QuizArenaDbContext : IdentityDbContext<User>
    {

        public QuizArenaDbContext()
            : this("QuizArenaConnection")
        {
        }

        public QuizArenaDbContext(string nameOfConnectionString)
            : base(nameOfConnectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<QuizArenaDbContext, Configuration>());
        }

        public IDbSet<Question> Questions { get; set; }
    }
}
