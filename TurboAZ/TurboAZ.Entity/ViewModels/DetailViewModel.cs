using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurboAZ.Entity.Models;

namespace TurboAZ.ViewModels
{
    public class DetailViewModel
    {
        public int AdId { get; set; }
       
        public List<Image> ImageUrl { get; set; }
       
        public string City { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Body { get; set; }

        public string Color { get; set; }

        public string Valute { get; set; }

        public string Fuel { get; set; }

        public string Transmission { get; set; }

        public string GearBox { get; set; }

        public string EngineVolume { get; set; }

        
        public string Year { get; set; }
        public double Price { get; set; }
        public int Hp { get; set; }
        public double Walk { get; set; }
        public bool CreditHave { get; set; }
        public bool Barter { get; set; }
        public string Note { get; set; }
        public bool AlloyWheels { get; set; }
        public bool CentralClosure { get; set; }
        public bool LeatherSalon { get; set; }
        public bool SeatVent { get; set; }
        public bool Abs { get; set; }
        public bool ParkRadar { get; set; }
        public bool XenonLamps { get; set; }
        public bool Lyuk { get; set; }
        public bool Conditioner { get; set; }
        public bool RearCamera { get; set; }
        public bool RainSensor { get; set; }
        public bool SeatHeating { get; set; }
        public bool SideCurtains { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Date { get; set; }
    }
}
