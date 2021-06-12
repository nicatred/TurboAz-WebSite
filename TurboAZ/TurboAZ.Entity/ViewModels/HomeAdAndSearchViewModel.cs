using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ.ViewModels;

namespace TurboAZ.Entity.ViewModels
{
    public class HomeAdAndSearchViewModel
    {
        public List<HomeAdViewModel> homeAdViewModels{ get; set; }

        public FillSelectViewModel fillSelectViewModel { get; set; }
    }
}
