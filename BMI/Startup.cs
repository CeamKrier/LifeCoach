using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BMI.Startup))]
namespace BMI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
