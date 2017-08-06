using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcMovieStore.Startup))]
namespace mvcMovieStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
