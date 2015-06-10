using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuizArena.Startup))]
namespace QuizArena
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
