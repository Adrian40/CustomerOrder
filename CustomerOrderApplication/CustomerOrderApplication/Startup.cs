using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerOrderApplication.Startup))]
namespace CustomerOrderApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
