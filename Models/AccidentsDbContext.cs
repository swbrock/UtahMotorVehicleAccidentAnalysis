using System;
using Microsoft.EntityFrameworkCore;
using UtahMotorVehicleAccidentAnalysis.Models;

namespace UtahMotorVehicleAccidentAnalysis.Models
{
    public class AccidentsDbContext : DbContext
    {
        public AccidentsDbContext(DbContextOptions<AccidentsDbContext> options) : base (options)
        {
        }

        public DbSet<Accident> Accidents { get; set; }
    }
}
