using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HaterDate2.Startup))]
namespace HaterDate2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
