using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TubroAZ.Businnes.Abstract;
using TurboAZ.Entity.Models;
using TurboAZ.Repository.Abstract;

namespace TubroAZ.Businnes.Concrete
{
    class FillSelectService : IFillSelectService
    {
        IFillSelectRepository fillSelectRepository;
        public FillSelectService(IFillSelectRepository fillSelectRepository)
        {
            this.fillSelectRepository = fillSelectRepository;
        }
        public List<Body> GetBodies()
        {
          return  fillSelectRepository.GetBodies();
        }

        public Body GetBodyById(int BodyId)
        {
            return fillSelectRepository.GetBodyById(BodyId);
        }

        public Brand GetBrandById(int BrandId)
        {
            return fillSelectRepository.GetBrandById(BrandId);
        }

        public List<Brand> GetBrands()
        {
           return fillSelectRepository.GetBrands();
        }

        public List<City> GetCities()
        {
            return fillSelectRepository.GetCities();
        }

        public City GetCityById(int CityId)
        {
            return fillSelectRepository.GetCityById(CityId);
        }

        public Color GetColorById(int ColorId)
        {
            return fillSelectRepository.GetColorById(ColorId);
        }

        public List<Color> GetColors()
        {
            return fillSelectRepository.GetColors();
        }

        public EngineVolume GetEngineVolumeById(int EngineVolumeId)
        {
            return fillSelectRepository.GetEngineVolumeById(EngineVolumeId);
        }

        public List<EngineVolume> GetEngineVolumes()
        {
            return fillSelectRepository.GetEngineVolumes();
        }

        public Fuel GetFuelById(int FuelId)
        {
            return fillSelectRepository.GetFuelById(FuelId);
        }

        public List<Fuel> GetFuels()
        {
            return fillSelectRepository.GetFuels();
        }

        public GearBox GetGearBoxById(int GearBoxId)
        {
            return fillSelectRepository.GetGearBoxById(GearBoxId);
        }

        public List<GearBox> GetGearBoxes()
        {
            return fillSelectRepository.GetGearBoxes();
        }

        public Model GetModelById(int ModelId)
        {
            return fillSelectRepository.GetModelById(ModelId);
        }

        public List<Model> GetModels(int BrandId)
        {
            return fillSelectRepository.GetModels(BrandId);
        }

        public Transmission GetTransmissionById(int TransmissionId)
        {
            return fillSelectRepository.GetTransmissionById(TransmissionId);
        }

        public List<Transmission> GetTransmissions()
        {
            return fillSelectRepository.GetTransmissions();
        }

        public Valute GetValuteById(int ValuteId)
        {
            return fillSelectRepository.GetValuteById(ValuteId);
        }

        public List<Valute> GetValutes()
        {
            return fillSelectRepository.GetValutes();
        }

        public Year GetYearById(int YearId)
        {
            return fillSelectRepository.GetYearById(YearId);
        }

        public List<Year> GetYears()
        {
            return fillSelectRepository.GetYears();
        }
    }
}
