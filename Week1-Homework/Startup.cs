using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week1_Homework.Startup))]
namespace Week1_Homework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
