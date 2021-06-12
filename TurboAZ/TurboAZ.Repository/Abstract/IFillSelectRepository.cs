using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ.Entity.Models;

namespace TurboAZ.Repository.Abstract
{
   public interface IFillSelectRepository
    {
        public List<Brand> GetBrands();
        public Brand GetBrandById(int BrandId);
        public List<Model> GetModels(int BrandId);
        public Model GetModelById(int ModelId);
        public List<Body> GetBodies();
        public Body GetBodyById(int BodyId);
        public List<Color> GetColors();
        public Color GetColorById(int ColorId);
        public List<Valute> GetValutes();
        public Valute GetValuteById(int ValuteId);
        public List<Fuel> GetFuels();
        public Fuel GetFuelById(int FuelId);
        public List<Transmission> GetTransmissions();
        public Transmission GetTransmissionById(int TransmissionId);
        public List<GearBox> GetGearBoxes();
        public GearBox GetGearBoxById(int GearBoxId);
        public List<EngineVolume> GetEngineVolumes();
        public EngineVolume GetEngineVolumeById(int EngineVolumeId);
        public List<Year> GetYears();
        public Year GetYearById(int YearId);
        public List<City> GetCities();
        public City GetCityById(int CityId);
    }

}
