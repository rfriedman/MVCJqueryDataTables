using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCJqueryDataTables.Startup))]
namespace MVCJqueryDataTables
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
