using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test2017Web.Startup))]
namespace Test2017Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
