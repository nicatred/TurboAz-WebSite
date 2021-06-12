using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TubroAZ.Businnes.Abstract;
using TurboAZ.Businnes.Abstract;
using TurboAZ.Entity.Models;
using TurboAZ.Entity.ViewModels;
using TurboAZ.Repository;
using TurboAZ.ViewModels;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace TurboAZ.Controllers
{
  
    public class AdsController : Controller
    {
        private readonly IAdsService _adsService;
        private readonly IFillSelectService _fillSelectService;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;
        private readonly IUploadImageService _uploadImageService;
        EfCoreDbContext efCoreDbContext = new EfCoreDbContext();
        FillSelectViewModel fillSelectViewModel = new FillSelectViewModel();
        HomeAdAndSearchViewModel homeAdAndSearchViewModel = new HomeAdAndSearchViewModel();

        public AdsController(IAdsService adsService, IFillSelectService fillSelectService,IMapper mapper, IWebHostEnvironment env, IUploadImageService uploadImageService)
        {
            _adsService = adsService;
            _fillSelectService = fillSelectService;
            _mapper = mapper;
            _env = env;
            _uploadImageService = uploadImageService;
        }
       
        public IActionResult Index()
        {


            
            homeAdAndSearchViewModel.homeAdViewModels = _adsService.GetHomeAds();
            Fuller();
            homeAdAndSearchViewModel.fillSelectViewModel = fillSelectViewModel;

            return View(homeAdAndSearchViewModel);
        }
      
        
        public IActionResult GetModels(int brandId) 
        {
            var models = efCoreDbContext.Models.Where(x => x.BrandId == brandId).Select(x => new {
                id = x.ModelId,
                name = x.ModelName
            }).ToList();
            
            return Json(models);
        }

       
        public IActionResult New()
        {
            Fuller();
            return View("_AddAdvertise",fillSelectViewModel);
        }

        void Fuller()
        {
            fillSelectViewModel.Brands = _fillSelectService.GetBrands();
            fillSelectViewModel.Cities = _fillSelectService.GetCities();
            fillSelectViewModel.Bodies = _fillSelectService.GetBodies();
            fillSelectViewModel.Colors = _fillSelectService.GetColors();
            fillSelectViewModel.Valutes = _fillSelectService.GetValutes();
            fillSelectViewModel.Fuels = _fillSelectService.GetFuels();
            fillSelectViewModel.Transmissions = _fillSelectService.GetTransmissions();
            fillSelectViewModel.GearBoxes = _fillSelectService.GetGearBoxes();
            fillSelectViewModel.EngineVolumes = _fillSelectService.GetEngineVolumes();
            fillSelectViewModel.Years = _fillSelectService.GetYears();
            var currencies = new SelectList(_fillSelectService.GetValutes(), "ValuteId", "ValuteName");
            ViewBag.Currencies = currencies;
        }
        
        [HttpPost]
        public IActionResult Save(AdViewModel ad)
        {
            ad.Date = DateTime.Now;
            var resultAd = _mapper.Map<AdViewModel,Ad>(ad);
            _adsService.Save(resultAd);
            ImageSave(ad);
   
            return RedirectToAction("Index");
        }
        void ImageSave(AdViewModel ad)
        {
            Ad resultAd= efCoreDbContext.Ads.OrderByDescending(e=>e.AdId).First();
            
            int typeId = 1;
            foreach (var item in ad.ImageFile)
            {
                Image image = new Image();
                string folder = "wwwroot/Adimg/";
                string imageName = Guid.NewGuid().ToString() + "_" + item.FileName;
                folder += imageName;             
                image.ImageUrl = imageName;
                image.ImageTypeId = typeId;
                image.AdId = resultAd.AdId;
                _uploadImageService.Save(image);

                item.CopyTo(new FileStream(folder, FileMode.Create));
                if (typeId < 4)
                {
                    typeId++;
                }
            }
        }
   
        public IActionResult Detail(int AdId)
        {         
            DetailViewModel detailViewModel = new DetailViewModel();
            detailViewModel = _adsService.GetDetailAd(AdId);
            return View(detailViewModel);
        }
       
        public IActionResult Search()
        {
           

            return View();
        }

    }
}
