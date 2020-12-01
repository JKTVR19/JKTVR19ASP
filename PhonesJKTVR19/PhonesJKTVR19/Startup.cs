using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhonesJKTVR19.Startup))]
namespace PhonesJKTVR19
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
