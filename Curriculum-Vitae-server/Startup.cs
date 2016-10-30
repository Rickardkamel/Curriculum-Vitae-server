using Curriculum_Vitae_server;
using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(Startup))]
namespace Curriculum_Vitae_server
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            WebApiConfig.Configure(app);
            
        }
    }
}