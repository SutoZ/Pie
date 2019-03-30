using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Pie.Models;

namespace Pie
{
    public class Startup
    {
        //Automatically called

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IPieRepository, MockPieRepository>();
            //Registering servie for application
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //Middleware components used to hadling HTTP requests.

#if DEBUG
            app.UseDeveloperExceptionPage();    //yellow exception page
            app.UseStatusCodePages();   //200, 404 etc.
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();   //use only after usStaticFiles
#endif
            /*
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
            */
        }
    }
}
