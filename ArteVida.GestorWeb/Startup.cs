using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArteVida.GestorWeb.Startup))]
namespace ArteVida.GestorWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            ConfigureAuth(app);

        }


    }


}
