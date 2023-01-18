using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace VWorkS
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddDbContext<ConnectDBContext>(cfg =>
                cfg.UseSqlServer(_config.GetConnectionString("ConnectConnection"))
            );
            //cambiar el namespace
            services.AddScoped<VWorkS.IConnectRepository, VWorkS.ConnectRepository>();

            services.AddControllersWithViews();

            services.AddMvc();

            services.AddControllers();


            
        //        services.AddRazorPages()
        //.AddRazorRuntimeCompilation();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(cfg =>
            {
                cfg.MapControllerRoute("Fallback",
                    "{controller}/{action}/{id?}",
                    new { controller = "Login", action = "Index" }
                    );
            }
            );
        }
    }
}
