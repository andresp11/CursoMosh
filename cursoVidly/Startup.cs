using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cursoVidly.Startup))]
namespace cursoVidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
