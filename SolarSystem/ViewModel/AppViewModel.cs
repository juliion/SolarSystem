using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.ViewModel
{
    public class AppViewModel
    {
        public StarsViewModel StarsVM { get; set; } = new StarsViewModel();
        public PlanetsViewModel PlanetsVM { get; set; } = new PlanetsViewModel();
    }
}
