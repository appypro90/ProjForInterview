using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjForInterview.Startup))]
namespace ProjForInterview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
