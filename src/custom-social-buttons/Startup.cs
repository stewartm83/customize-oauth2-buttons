using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(custom_social_buttons.Startup))]
namespace custom_social_buttons
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
