using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjercicioQR.Startup))]
namespace EjercicioQR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
