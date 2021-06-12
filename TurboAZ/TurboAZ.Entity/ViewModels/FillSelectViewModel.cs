using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurboAZ.Entity.Models;

namespace TurboAZ.ViewModels
{
    public class FillSelectViewModel
    {
        public List<Brand> Brands { get; set; }
        public List<Model> Models { get; set; }
        public List<City> Cities { get; set; }
        public List<Body> Bodies { get; set; }
        public List<Color> Colors { get; set; }
        public List<Valute> Valutes { get; set; }
        public List<Fuel> Fuels { get; set; }
        public List<Transmission> Transmissions { get; set; }
        public List<GearBox> GearBoxes { get; set; }
        public List<EngineVolume> EngineVolumes { get; set; }
        public List<Year> Years { get; set; }
        public AdViewModel Ad { get; set; }
      

    }
}
