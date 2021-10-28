using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(theBAPapp.WebMVC.Startup))]
namespace theBAPapp.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
