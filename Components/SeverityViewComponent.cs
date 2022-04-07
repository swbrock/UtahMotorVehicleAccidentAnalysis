using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using UtahMotorVehicleAccidentAnalysis.Models;

namespace UtahMotorVehicleAccidentAnalysis.Components
{
    public class SeverityViewComponent : ViewComponent
    {
        private IAccidentsRepository repo { get; set; }
        public SeverityViewComponent(IAccidentsRepository temp)
        {
            repo = temp;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.SelectedType = RouteData?.Values["severity"];

            var severity = repo.Accidents
                .Select(x => x.crash_severity_id)
                .Distinct()
                .OrderBy(x => x);
            return View(severity);
        }
    }
}