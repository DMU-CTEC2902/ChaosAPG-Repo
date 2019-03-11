using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilmReviewMVC.Startup))]
namespace FilmReviewMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
