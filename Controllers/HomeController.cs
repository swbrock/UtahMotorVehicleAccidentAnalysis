using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UtahMotorVehicleAccidentAnalysis.Models;

namespace UtahMotorVehicleAccidentAnalysis.Controllers
{
    public class HomeController : Controller
    {
        private IAccidentsRepository repo { get; set; }

        private AccidentsDbContext context { get; set; }

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

        public IActionResult Factors(int factor)
        {
            var crashes = repo.Accidents.ToList();

            if (factor == 1)
            {
                crashes = repo.Accidents
                    .Where(x => x.work_zone_related == "TRUE")
                    .ToList();
            }
            if (factor == 2)
            {
                crashes = repo.Accidents
                    .Where(x => x.pedestrian_involved == "TRUE")
                    .ToList();
            }
            if (factor == 3)
            {
                crashes = repo.Accidents
                    .Where(x => x.bicyclist_involved == "TRUE")
                    .ToList();
            }
            if (factor == 4)
            {
                crashes = repo.Accidents
                    .Where(x => x.motorcycle_involved == "TRUE")
                    .ToList();
            }
            if (factor == 5)
            {
                crashes = repo.Accidents
                    .Where(x => x.improper_restraint == "TRUE")
                    .ToList();
            }
            if (factor == 6)
            {
                crashes = repo.Accidents
                    .Where(x => x.unrestrained == "TRUE")
                    .ToList();
            }
            if (factor == 7)
            {
                crashes = repo.Accidents
                    .Where(x => x.dui == "TRUE")
                    .ToList();
            }
            if (factor == 8)
            {
                crashes = repo.Accidents
                    .Where(x => x.intersection_related == "TRUE")
                    .ToList();
            }
            if (factor == 9)
            {
                crashes = repo.Accidents
                    .Where(x => x.wild_animal_related == "TRUE")
                    .ToList();
            }
            if (factor == 10)
            {
                crashes = repo.Accidents
                    .Where(x => x.domestic_animal_related == "TRUE")
                    .ToList();
            }
            if (factor == 11)
            {
                crashes = repo.Accidents
                    .Where(x => x.overturn_rollover == "TRUE")
                    .ToList();
            }
            if (factor == 12)
            {
                crashes = repo.Accidents
                    .Where(x => x.commercial_motor_veh_involved == "TRUE")
                    .ToList();
            }
            if (factor == 13)
            {
                crashes = repo.Accidents
                    .Where(x => x.teenage_driver_involved == "TRUE")
                    .ToList();
            }
            if (factor == 14)
            {
                crashes = repo.Accidents
                    .Where(x => x.older_driver_involved == "TRUE")
                    .ToList();
            }
            if (factor == 15)
            {
                crashes = repo.Accidents
                    .Where(x => x.night_dark_condition == "TRUE")
                    .ToList();
            }
            if (factor == 16)
            {
                crashes = repo.Accidents
                    .Where(x => x.single_vehicle == "TRUE")
                    .ToList();
            }
            if (factor == 17)
            {
                crashes = repo.Accidents
                    .Where(x => x.distracted_driving == "TRUE")
                    .ToList();
            }
            if (factor == 18)
            {
                crashes = repo.Accidents
                    .Where(x => x.drowsy_driving == "TRUE")
                    .ToList();
            }
            if (factor == 19)
            {
                crashes = repo.Accidents
                    .Where(x => x.roadway_departure == "TRUE")
                    .ToList();
            }
            

            return View(crashes);
        }

        public IActionResult DriveSafe()
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
        public IActionResult Edit(int id)
        {
            var details = repo.Accidents
                .Where(x => x.crash_id == id)
                .FirstOrDefault();

            return View("AddEditAccident", details);
        }

        [Authorize(Policy = "writepolicy")]
        [HttpPost]
        public IActionResult Edit(Accident a)
        {
            repo.SaveAccident(a);

            return RedirectToAction("Database");
        }

        [Authorize(Policy = "writepolicy")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var crash = repo.Accidents.Single(x => x.crash_id == id);

            return View(crash);
        }

        [Authorize(Policy = "writepolicy")]
        [HttpPost]
        public IActionResult Delete(Accident a)
        {
            repo.DeleteAccident(a);

            return RedirectToAction("Database");
        }
        
        [Authorize(Policy = "writepolicy")]
        [HttpGet]
        public IActionResult AddAccident()
        {
            var bowler = repo.Accidents.Select(x => x.crash_id);

            return View("AddEditAccident");
        }

        [Authorize(Policy = "writepolicy")]
        [HttpPost]
        public IActionResult AddAccident(Accident a)
        {
            if (ModelState.IsValid)
            {
                repo.CreateAccident(a);

                return View("Confirmation", a);
            }

            else //if invalid
            {
                return View("AddEditAccident", a);
            }

        }
    }
}
