using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapAndAngularJs.Startup))]
namespace BootstrapAndAngularJs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
