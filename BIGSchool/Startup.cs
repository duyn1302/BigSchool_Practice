using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BIGSchool.Startup))]
namespace BIGSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
