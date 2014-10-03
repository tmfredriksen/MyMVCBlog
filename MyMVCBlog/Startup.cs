using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMVCBlog.Startup))]
namespace MyMVCBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
