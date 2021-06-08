using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ocean.Startup))]
namespace Ocean
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
