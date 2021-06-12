using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TubroAZ.Businnes.ValidationRules;
using TurboAZ.Businnes;
using TurboAZ.Entity.Models;
using TurboAZ.Repository;
using TurboAZ.Repository.Identity;

namespace TurboAZ
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        //public UserManager<AppUser> userManager { get; set; }
        //public RoleManager<IdentityRole> roleManager { get; set; }
        public IConfiguration Configuration { get; }
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //this.userManager = userManager;
            //this.roleManager = roleManager;

        }
       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddFluentValidation();
            services.AddRepository(Configuration);
            services.AddBusinessLayer();

            services.AddTransient<IValidator<Ad>, AdValidator>();
            services.AddAutoMapper(typeof(Startup));
            //  services.AddDbContext<EfCoreDbContext>();

         //   services.AddIdentity<AppUser, IdentityRole>(opt =>
         //   {
         //       opt.Password.RequireDigit = false;
         //       opt.Password.RequireLowercase = false;
         //       opt.Password.RequiredLength = 6;
         //       opt.Password.RequireUppercase = false;
         //       opt.Password.RequireNonAlphanumeric = false;
         //   }).AddEntityFrameworkStores<EfCoreDbContext>();
         //   services.ConfigureApplicationCookie(opt =>
         //   {
         //       opt.LoginPath = new PathString("/Login/AdminLogin");
         //       opt.Cookie.Name = "usercookie";
         //       opt.Cookie.HttpOnly = true;
         //       opt.Cookie.SameSite = SameSiteMode.Strict;
         //       opt.ExpireTimeSpan = TimeSpan.FromMinutes(30);
         //   }
         //);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.UseCookiePolicy();
          
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Default",
                    
                    pattern: "{controller=Login}/{action=UserLogin}/{id?}"
                    );

            endpoints.MapControllerRoute(
          name: "areas",
          pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
        );
         
            });
           // IdentitySeed.CreateAdmin(userManager, roleManager);
        }
      
    }

}
