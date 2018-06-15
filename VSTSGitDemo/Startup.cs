using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VSTSGitDemo.Startup))]
namespace VSTSGitDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
