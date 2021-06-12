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
    public class UploadImageService : IUploadImageService
    {
          private readonly IUploadImageRepository _uploadImageRepository;
        public UploadImageService(IUploadImageRepository uploadImageRepository)
        {
            _uploadImageRepository = uploadImageRepository;
        }
        public void Delete(Image Image)
        {
            _uploadImageRepository.Delete(Image);
        }

        public Image GetById(int Id)
        {
            return _uploadImageRepository.GetById(Id);
        }

        public Image GetFrontImageByAdId(int AdId)
        {
            return _uploadImageRepository.GetFrontImageByAdId(AdId);
        }

        public List<Image> GetImagesByAdId(int AdId)
        {
            return _uploadImageRepository.GetImagesByAdId(AdId);
        }

        public List<Image> GetList()
        {
            return _uploadImageRepository.GetList();
        }

        public void Save(Image Image)
        {
            _uploadImageRepository.Save(Image);
        }

        public void UPDATE(Image Image)
        {
            _uploadImageRepository.Update(Image);
        }
    }
}
