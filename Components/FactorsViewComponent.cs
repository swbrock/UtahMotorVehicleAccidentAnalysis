using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using UtahMotorVehicleAccidentAnalysis.Models;

namespace UtahMotorVehicleAccidentAnalysis.Components
{
    public class FactorsViewComponent : ViewComponent
    {
        private IAccidentsRepository repo { get; set; }
        public FactorsViewComponent(IAccidentsRepository temp)
        {
            repo = temp;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.SelectedType = RouteData?.Values["factor"];

            var factors = repo.Accidents.ToList();


            return View(factors);

        }
    }
}
