using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NinoCasino.Startup))]
namespace NinoCasino
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
