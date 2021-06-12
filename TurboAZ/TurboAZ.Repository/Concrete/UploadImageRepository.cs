using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ.Entity.Models;
using TurboAZ.Repository.Abstract;


namespace TurboAZ.Repository.Concrete
{
    public class UploadImageRepository: GenericRepository<Image>, IUploadImageRepository
    {
        public List<Image> GetImagesByAdId(int AdId)
        {
            using(EfCoreDbContext efCoreDbContext = new EfCoreDbContext())
            {
               return efCoreDbContext.Images.Where(e => e.AdId == AdId && e.ImageTypeId>1).ToList();
            }
        }
        public Image GetFrontImageByAdId(int AdId)
        { 
           
            using (EfCoreDbContext efCoreDbContext = new EfCoreDbContext())
            {
                
                return efCoreDbContext.Images.Where(e => e.AdId == AdId && e.ImageTypeId ==1).FirstOrDefault();
               
            }
        }
    }

}
