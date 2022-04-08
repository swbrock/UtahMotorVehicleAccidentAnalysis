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

        public IActionResult Database(int severity)
        {
            var severities = repo.Accidents
                .Where(x => x.crash_severity_id == severity || severity == 0)
                .ToList();

            return View(severities);
        }

        public IActionResult Details(int id)
        {
            var details = repo.Accidents
                .Where(x => x.crash_id == id)
                .FirstOrDefault();

            return View(details);
        }

        public IActionResult Counties(string county)
        {
            var counties = repo.Accidents
                .Where(x => x.county_name == county || county == null)
                .ToList();
            return View(counties);
        }

        public IActionResult City(string city)
        {
            var details = repo.Accidents
                .Where(x => x.city == city)
                .ToList();

            return View(details);
        }

        public IActionResult Factors()
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]
        [Authorize(Policy = "writepolicy")]
        public IActionResult Edit(int crash_id)
        {
            var crash = repo.Accidents
                .Where(x => x.crash_id == crash_id)
                .FirstOrDefault();

            return View("AddEditAccident", crash);
        }

        [Authorize(Policy = "writepolicy")]
        [HttpPost]
        public IActionResult Edit(Accident a)
        {
            repo.SaveAccident(a);

            return RedirectToAction("Index");
        }

        [Authorize(Policy = "writepolicy")]
        [HttpGet]
        public IActionResult Delete(int crash_id)
        {
            var crash = repo.Accidents.Single(x => x.crash_id == crash_id);

            return View(crash);
        }

        [Authorize(Policy = "writepolicy")]
        [HttpPost]
        public IActionResult Delete(Accident a)
        {
            repo.DeleteAccident(a);

            return RedirectToAction("Index");
        }
    }
}
