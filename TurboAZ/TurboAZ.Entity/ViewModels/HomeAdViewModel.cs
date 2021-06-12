using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurboAZ.Entity.Models;

namespace TurboAZ.ViewModels
{
    public class HomeAdViewModel
    {
        public int AdId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public string ImageName { get; set; }
        public string Year { get; set; }
        public string EngineVolume { get; set; }
        public double Walk { get; set; }
        public string City { get; set; }
        public string Date { get; set; }
        public  string Valute { get; set; }

        public FillSelectViewModel fillSelectViewModel { get; set; }

    }
}
