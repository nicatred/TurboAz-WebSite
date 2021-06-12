using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ.Entity.Models;
using TurboAZ.Repository.Abstract;
using TurboAZ.ViewModels;

namespace TurboAZ.Repository.Concrete
{
    public class AdsRepository : GenericRepository<Ad>, IAdsRepository
    {
        public DetailViewModel GetDetailAd(int AdId)
        {
            using (var context = new EfCoreDbContext())
            {
                var result = from a in context.Ads
                             select new DetailViewModel
                             {
                                 AdId = a.AdId,
                                 ImageUrl = a.Images,
                                 City = a.City.CityName,
                                 Brand = a.Brand.BrandName,
                                 Model = a.Model.ModelName,
                                 Body = a.Body.BodyName,
                                 Color = a.Color.ColorName,
                                 Valute = a.Valute.ValuteName,
                                 Fuel = a.Fuel.FuelName,
                                 Transmission = a.Transmission.TransmissionName,
                                 GearBox = a.GearBox.GearBoxName,
                                 EngineVolume = String.Format("{0:0.0}", a.EngineVolume.EngineVolumeName / 1000),
                                 Year = a.Year.YearName,
                                 Price = a.Price,
                                 Hp = a.Hp,
                                 Walk = a.Walk,
                                 CreditHave = a.CreditHave,
                                 Barter = a.Barter,
                                 Note = a.Note,
                                 AlloyWheels = a.AlloyWheels,
                                 CentralClosure = a.CentralClosure,
                                 LeatherSalon = a.LeatherSalon,
                                 SeatVent = a.SeatVent,
                                 Abs = a.Abs,
                                 ParkRadar = a.ParkRadar,
                                 XenonLamps = a.XenonLamps,
                                 Lyuk = a.Lyuk,
                                 Conditioner = a.Conditioner,
                                 RearCamera = a.RearCamera,
                                 RainSensor = a.RainSensor,
                                 SeatHeating = a.SeatHeating,
                                 SideCurtains = a.SideCurtains,
                                 Name = a.Name,
                                 Email = a.Email,
                                 Date = a.Date.ToString("MM.dd.yyyy HH:mm")

                             };
                return result.FirstOrDefault(a=>a.AdId==AdId);

            }
        }

        public List<HomeAdViewModel> GetHomeAds()
        {
            using (var context = new EfCoreDbContext())
            {
                var result = from a in context.Ads
                             select new HomeAdViewModel
                             {
                                 AdId = a.AdId,
                                 Brand = a.Brand.BrandName,
                                 Model = a.Model.ModelName,
                                 Price = a.Price,
                                 ImageName = a.Images.FirstOrDefault().ImageUrl,
                                 Year = a.Year.YearName,
                                 EngineVolume = String.Format("{0:0.0}", a.EngineVolume.EngineVolumeName / 1000),
                                 Walk = a.Walk,
                                 City = a.City.CityName,
                                 Date = a.Date.ToString("MM.dd.yyyy HH:mm"),
                                 Valute = a.Valute.ValuteName
                             };
                return result.ToList();

            }

        }

    }
}

       
    

