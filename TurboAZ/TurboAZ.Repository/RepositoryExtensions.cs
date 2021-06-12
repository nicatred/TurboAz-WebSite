using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ.Repository.Abstract;
using TurboAZ.Repository.Concrete;
using TurboAZ.Repository.Identity;

namespace TurboAZ.Repository
{
   public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepository(this IServiceCollection services, IConfiguration configuration)
        {
            AddDbContext(services, configuration);
            RegisterDependencies(services);
            AddIdentity(services);
            return services;
             
        }
        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EfCoreDbContext>();
            //services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<EfCoreDbContext>();
        }

        private static void RegisterDependencies(IServiceCollection services)
        {
            services.AddScoped<IAdsRepository, AdsRepository>();
            services.AddScoped<IFillSelectRepository, FillSelectRepository>();
            services.AddScoped<IUploadImageRepository, UploadImageRepository>();
        }
        private static void AddIdentity(IServiceCollection services)
        {
            services.AddIdentity<AppUser, IdentityRole>(opt =>
            {
                opt.Password.RequireDigit = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequiredLength = 6;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<EfCoreDbContext>();
         //   services.ConfigureApplicationCookie(opt =>
         //   {
         //       opt.LoginPath = new PathString("/Login/UserLogin/");
         //       opt.Cookie.Name = "CrudWebApp";
         //       opt.Cookie.HttpOnly = true;
         //       opt.Cookie.SameSite = SameSiteMode.Strict;
         //       opt.ExpireTimeSpan = TimeSpan.FromMinutes(30);
         //   }
         //);
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme
                ).AddCookie(options =>
            {
                options.LoginPath = new PathString("/Login/UserLogin/");
                options.AccessDeniedPath = new PathString("/Login/UserLogin");
            });
        }
    }
}
