using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WarriorCombatAcademyTrainer.Startup))]
namespace WarriorCombatAcademyTrainer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
