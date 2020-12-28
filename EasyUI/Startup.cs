using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasyUI.Startup))]
namespace EasyUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
