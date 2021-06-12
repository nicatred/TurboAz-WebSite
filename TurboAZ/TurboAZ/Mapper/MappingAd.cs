using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurboAZ.Entity.Models;
using TurboAZ.ViewModels;

namespace TurboAZ.Mapper
{
    public class MappingAd:Profile
    {
        public MappingAd()
        {
            CreateMap<AdViewModel, Ad>();
        }
    }
}
