using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ.Businnes.Abstract;
using TurboAZ.Entity.Models;
using TurboAZ.Repository.Abstract;
using TurboAZ.ViewModels;

namespace TurboAZ.Businnes.Concrete
{
    class AdsService : IAdsService
    {
        IAdsRepository adsRepository;
        public AdsService(IAdsRepository adsRepository)
        {
            this.adsRepository = adsRepository;
        }
        public void Delete(Ad Ads)
        {
            adsRepository.Delete(Ads);
        }

        public Ad GetById(int Id)
        {
           return adsRepository.GetById(Id);
        }

        public DetailViewModel GetDetailAd(int AdId)
        {
            return adsRepository.GetDetailAd(AdId);
        }

        public List<HomeAdViewModel> GetHomeAds()
        {
           return adsRepository.GetHomeAds();
        }

        public List<Ad> GetList()
        {
            return adsRepository.GetList();
        }

        public void Save(Ad Ads)
        {
             adsRepository.Save(Ads);

        }

        public void UPDATE(Ad Ads)
        {
            adsRepository.Update(Ads);
        }
    }
}
