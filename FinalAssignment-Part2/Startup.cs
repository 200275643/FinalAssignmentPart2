using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalAssignment_Part2.Startup))]
namespace FinalAssignment_Part2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
