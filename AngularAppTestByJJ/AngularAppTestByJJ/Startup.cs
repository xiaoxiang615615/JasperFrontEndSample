using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularAppTestByJJ.Startup))]
namespace AngularAppTestByJJ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
