using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestRepo.Startup))]
namespace TestRepo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
