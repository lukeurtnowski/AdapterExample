using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdaptersExamplle.Startup))]
namespace AdaptersExamplle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
