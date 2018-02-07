using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentAdminPannel.Startup))]
namespace RentAdminPannel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
