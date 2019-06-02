using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Owin;
using RedyFitness.Data;
using Microsoft.Owin.Security.Cookies;



[assembly: OwinStartup(typeof(RedyFitness.Startup))]

namespace RedyFitness
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<Context>(Context.Create);
            app.CreatePerOwinContext<UserManager>(UserManager.Create);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/User/Login"),
            });
        }
    }
}
