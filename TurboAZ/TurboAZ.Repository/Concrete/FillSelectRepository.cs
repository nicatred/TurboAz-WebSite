using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ.Entity.Models;
using TurboAZ.Repository.Abstract;

namespace TurboAZ.Repository.Concrete
{
    public class FillSelectRepository : IFillSelectRepository
    {
        public List<Body> GetBodies()
        {
            using(EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Bodies.ToList();
                return resultList;
            }
        }
        public Body GetBodyById(int BodyId)
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Bodies.Find(BodyId);
                return resultList;
            }
        }


        public List<Brand> GetBrands()
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Brands.ToList();
                return resultList;
            }
        }
        public Brand GetBrandById(int BrandId)
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Brands.Find(BrandId);
                return resultList;
            }
        }
        public List<City> GetCities()
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Cities.ToList();
                return resultList;
            }
        }
        public City GetCityById(int CityId)
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Cities.Find(CityId);
                return resultList;
            }
        }

        public List<Color> GetColors()
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Colors.ToList();
                return resultList;
            }
        }
        public Color GetColorById(int ColorId)
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Colors.Find(ColorId);
                return resultList;
            }
        }
        public List<EngineVolume> GetEngineVolumes()
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.EngineVolumes.ToList();
                return resultList;
            }
        }
        public EngineVolume GetEngineVolumeById(int EngineVolumeId)
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.EngineVolumes.Find(EngineVolumeId);
                return resultList;
            }
        }

        public List<Fuel> GetFuels()
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Fuels.ToList();
                return resultList;
            }
        }
        public Fuel GetFuelById(int FuelId)
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Fuels.Find(FuelId);
                return resultList;
            }
        }

        public List<GearBox> GetGearBoxes()
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.GearBox.ToList();
                return resultList;
            }
        }
        public GearBox GetGearBoxById(int GearBoxId)
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.GearBox.Find(GearBoxId);
                return resultList;
            }
        }

        public List<Model> GetModels(int BrandId)
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Models.Where(e => e.BrandId == BrandId).ToList();
                return resultList;
            }
        }
        public Model GetModelById(int ModelId)
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Models.Find(ModelId);
                return resultList;
            }
        }

        public List<Transmission> GetTransmissions()
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Transmissions.ToList();
                return resultList;
            }
        }
        public Transmission GetTransmissionById(int TransmissionId)
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Transmissions.Find(TransmissionId);
                return resultList;
            }
        }

        public List<Valute> GetValutes()
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Valutes.ToList();
                return resultList;
            }
        }
        public Valute GetValuteById(int ValuteId)
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Valutes.Find(ValuteId);
                return resultList;
            }
        }

        public List<Year> GetYears()
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Years.ToList();
                return resultList;
            }
        }
        public Year GetYearById(int YearId)
        {
            using (EfCoreDbContext dbContext = new EfCoreDbContext())
            {
                var resultList = dbContext.Years.Find(YearId);
                return resultList;
            }
        }

       
    }
}
