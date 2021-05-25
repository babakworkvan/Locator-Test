using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_Locator.Startup))]
namespace Test_Locator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
