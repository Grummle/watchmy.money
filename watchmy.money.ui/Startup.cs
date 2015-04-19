using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(watchmy.money.Startup))]
namespace watchmy.money
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
