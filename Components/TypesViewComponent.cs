﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using UtahMotorVehicleAccidentAnalysis.Models;

namespace UtahMotorVehicleAccidentAnalysis.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private IAccidentsRepository repo { get; set; }
        public TypesViewComponent(IAccidentsRepository temp)
        {
            repo = temp;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.SelectedType = RouteData?.Values["county"];

            var types = repo.Accidents
                .Select(x => x.COUNTY_NAME)
                .Distinct()
                .OrderBy(x => x);
            return View(types);
        }
    }
}
