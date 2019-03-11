using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_TauDeltaChiDotCom.Startup))]
namespace MVC_TauDeltaChiDotCom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
