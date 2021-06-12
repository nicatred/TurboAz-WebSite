using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ.Entity.Models;
using TurboAZ.ViewModels;

namespace TurboAZ.Businnes.Abstract
{
   public interface IAdsService
    {
        List<Ad> GetList();
        Ad GetById(int Id);
        void Save(Ad Ads);
        void Delete(Ad Ads);
        void UPDATE(Ad Ads);
        List<HomeAdViewModel> GetHomeAds();
        DetailViewModel GetDetailAd(int AdId);
    }
}
