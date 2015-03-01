using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JasperMVCContextMenuTest.Startup))]
namespace JasperMVCContextMenuTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
