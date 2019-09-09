using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chappel_MIS4200.Startup))]
namespace Chappel_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
