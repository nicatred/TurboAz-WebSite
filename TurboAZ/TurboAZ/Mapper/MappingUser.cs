using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurboAZ.Entity.ViewModels;
using TurboAZ.Repository.Identity;

namespace TurboAZ.Mapper
{
    public class MappingUser:Profile
    {
        public MappingUser()
        {
            CreateMap<UserViewModel, AppUser>();
        }
    }
}
