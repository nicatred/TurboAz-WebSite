using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ.Entity.Models;

namespace TurboAZ.Repository.Abstract
{
   public interface IUploadImageRepository:IGenericRepository<Image>
    {
        public List<Image> GetImagesByAdId(int AdId);
        public Image GetFrontImageByAdId(int AdId);
    }
}
