using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssognmentEnterprice.Startup))]
namespace AssognmentEnterprice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
