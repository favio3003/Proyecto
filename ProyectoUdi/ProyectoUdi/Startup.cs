using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoUdi.Startup))]
namespace ProyectoUdi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
