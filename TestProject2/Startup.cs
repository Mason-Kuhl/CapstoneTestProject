using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestProject2.Startup))]
namespace TestProject2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
