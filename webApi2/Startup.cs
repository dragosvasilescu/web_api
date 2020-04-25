using System;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace webApi2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddControllers();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           
            //app.Use(async (context, next) =>
            //{

            //    string authHeader = context.Request.Headers["Authorization"];
            //    if (authHeader != null)
            //    {
            //        var authHeaderValue = AuthenticationHeaderValue.Parse(authHeader);
            //        if (authHeaderValue.Scheme.ToUpper() == "BASIC")
            //        {
            //            var credentials = Encoding.UTF8
            //                            .GetString(Convert.FromBase64String(authHeaderValue.Parameter ?? string.Empty))
            //                            .Split(':', 2);
            //            string username = credentials[0];
            //            string password = credentials[1];
            //            if (username == "dragos" && password == "dragos")
            //            {
            //                await next();
            //            }
            //        }
            //    }

            //    string _realm = string.Empty;
            //    context.Response.Headers["WWW-Authenticate"] = $"Basic realm=\"{_realm}\"";
            //    context.Response.StatusCode = 401;
            //    return;

            //});
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();
            
            app.UseMyMiddleware();
            app.UseAuthMiddleware(); 

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
        }
    }
}
