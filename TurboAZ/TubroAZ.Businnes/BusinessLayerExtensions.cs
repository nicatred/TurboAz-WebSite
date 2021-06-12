using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TubroAZ.Businnes.Abstract;
using TubroAZ.Businnes.Concrete;
using TurboAZ.Businnes.Abstract;
using TurboAZ.Businnes.Concrete;

namespace TurboAZ.Businnes
{
  public static  class BusinessLayerExtensions
    {
        
        public static IServiceCollection AddBusinessLayer(this IServiceCollection services)
        {
            services.AddScoped<IAdsService, AdsService>();
            services.AddScoped<IFillSelectService, FillSelectService>();
            services.AddScoped<IUploadImageService, UploadImageService>();
           
            return services;
        }
    }
}
