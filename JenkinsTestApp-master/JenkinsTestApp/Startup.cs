using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsTestApp.Startup))]
namespace JenkinsTestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
