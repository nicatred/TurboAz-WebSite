using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ.Entity.Models;

namespace TubroAZ.Businnes.Abstract
{
    public interface IUploadImageService
    {
        List<Image> GetList();
        Image GetById(int Id);
        void Save(Image Image);
        void Delete(Image Image);
        void UPDATE(Image Image);
        public Image GetFrontImageByAdId(int AdId);
        public List<Image> GetImagesByAdId(int AdId);
    }
}
