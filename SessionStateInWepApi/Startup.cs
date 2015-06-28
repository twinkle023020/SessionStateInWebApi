using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SessionStateInWepApi.Startup))]
namespace SessionStateInWepApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
