using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ELMAHErrorLoggin.Startup))]
namespace ELMAHErrorLoggin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
