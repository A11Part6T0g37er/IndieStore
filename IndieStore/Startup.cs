using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IndieStore.Startup))]
namespace IndieStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
