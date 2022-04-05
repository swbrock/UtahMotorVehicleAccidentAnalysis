using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UtahMotorVehicleAccidentAnalysis.Data;

[assembly: HostingStartup(typeof(UtahMotorVehicleAccidentAnalysis.Areas.Identity.IdentityHostingStartup))]
namespace UtahMotorVehicleAccidentAnalysis.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}