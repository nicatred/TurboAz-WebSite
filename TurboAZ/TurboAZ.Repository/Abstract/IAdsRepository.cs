using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ.Entity.Models;
using TurboAZ;
using TurboAZ.ViewModels;

namespace TurboAZ.Repository.Abstract
{
    public interface IAdsRepository:IGenericRepository<Ad>
    {
        public List<HomeAdViewModel> GetHomeAds();
        public DetailViewModel GetDetailAd(int AdId);
    }
}
