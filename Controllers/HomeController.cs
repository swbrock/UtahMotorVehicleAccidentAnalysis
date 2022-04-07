using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UtahMotorVehicleAccidentAnalysis.Models;

namespace UtahMotorVehicleAccidentAnalysis.Controllers
{
    public class HomeController : Controller
    {
        private IAccidentsRepository repo { get; set; }

        public HomeController(IAccidentsRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Prediction()
        {
            return View();
        }

        public IActionResult Counties(string county)
        {
            var counties = repo.Accidents
                .Where(x => x.COUNTY_NAME == county || county == null)
                .ToList();           
            return View(counties);
        }

        public IActionResult City(string city)
        {
            var details = repo.Accidents
                .Where(x => x.CITY == city)
                .ToList();

            return View(details);
        }

        public IActionResult Accidents()
        {
            return View();
        }

        public IActionResult DriveSafe()
        {
            return View();
        }

        [Authorize(Policy = "writepolicy")]
        public IActionResult AddEditAccident()
        {
            return View();
        }
        [Authorize(Policy = "writepolicy")]
        public IActionResult Delete()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
