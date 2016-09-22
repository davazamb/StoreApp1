using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreApp1.Startup))]
namespace StoreApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
