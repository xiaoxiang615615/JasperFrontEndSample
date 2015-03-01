using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JasperJqueryMobile.Startup))]
namespace JasperJqueryMobile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
