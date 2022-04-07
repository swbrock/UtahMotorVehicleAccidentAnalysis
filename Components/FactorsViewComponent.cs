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
            ViewBag.SelectedType = RouteData?.Values["county"];

            var factors = typeof(Accident).GetProperties();

            return View(factors);

            //var work = Model.Where(x => x.work_zone_related == "TRUE").Count();
            //var ped = Model.Where(x => x.pedestrian_involved == "TRUE").Count();
            //var bic = Model.Where(x => x.bicyclist_involved == "TRUE").Count();
            //var motor = Model.Where(x => x.motorcycle_involved == "TRUE").Count();
            //var imp = Model.Where(x => x.improper_restraint == "TRUE").Count();
            //var unres = Model.Where(x => x.unrestrained == "TRUE").Count();
            //var dui = Model.Where(x => x.dui == "TRUE").Count();
            //var inter = Model.Where(x => x.intersection_related == "TRUE").Count();
            //var wild = Model.Where(x => x.wild_animal_related == "TRUE").Count();
            //var dom = Model.Where(x => x.domestic_animal_related == "TRUE").Count();
            //var over = Model.Where(x => x.overturn_rollover == "TRUE").Count();
            //var comm = Model.Where(x => x.commercial_motor_veh_involved == "TRUE").Count();
            //var teen = Model.Where(x => x.teenage_driver_involved == "TRUE").Count();
            //var older = Model.Where(x => x.older_driver_involved == "TRUE").Count();
            //var night = Model.Where(x => x.night_dark_condition == "TRUE").Count();
            //var single = Model.Where(x => x.single_vehicle == "TRUE").Count();
            //var dist = Model.Where(x => x.distracted_driving == "TRUE").Count();
            //var drow = Model.Where(x => x.drowsy_driving == "TRUE").Count();
            //var roadway = Model.Where(x => x.roadway_departure == "TRUE").Count();
        }
    }
}
