using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ELMAHErrorLoggin1.Startup))]
namespace ELMAHErrorLoggin1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
