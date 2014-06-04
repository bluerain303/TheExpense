using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheExpense.Startup))]
namespace TheExpense
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
