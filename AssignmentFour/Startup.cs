using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssignmentFour.Startup))]
namespace AssignmentFour
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
