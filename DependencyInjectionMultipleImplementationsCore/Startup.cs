using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionMultipleImplementationsCore.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DependencyInjectionMultipleImplementationsCore
{
    public class Startup
    {
         public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<CrudRepository, CrudRepositoryMongoDB>();
            services.AddScoped<CrudRepository, CrudRepositoryMySQL>();
            services.AddScoped<CrudRepository, CrudRepositorySqlServer>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
               name: "default",
                pattern:"{controller=Home}/{action=Index}/{id}" );
            });
        }
    }
}
