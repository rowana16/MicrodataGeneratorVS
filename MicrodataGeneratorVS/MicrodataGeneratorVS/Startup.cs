using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MicrodataGeneratorVS.Startup))]
namespace MicrodataGeneratorVS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
