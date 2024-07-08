using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persone.Models.Services.Application.Persone;
using Persone.Models.Services.Application.Auto;
using Persone.Models.Services.Infrastructure;
using Persone.Models.ViewModels;
using Persone.Models.Entities;

namespace Persone
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            // sto indicando ad ASP.NET Core che, quando un componente dipende dall'interfaccia IPersoneService
            // crea un oggetto della classe PersoneService
            // services.AddTransient<IPersoneService, PersoneService>();
            // services.AddTransient<IPersoneService, AdoNetPersonaService>();
            services.AddTransient<IDatabaseAccessor, SqliteDatabaseAccessor>();
            services.AddTransient<IAutoService, AdoNetAutoService>();
            services.AddTransient<IPersoneService, EfCorePersoneService>();
            //metodo per indicare che l'app usa la classe MyCourseDbContext come DbContext
            services.AddDbContext<PersonaDbContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // lifetime.ApplicationStarted.Register(()=>{
                //     string filePath = Path.Combine(env.ContentRootPath, "bin/reload.txt");
                //     File.WriteAllText(filePath, DataTime.Now.ToString());
                // });

            }
                
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
