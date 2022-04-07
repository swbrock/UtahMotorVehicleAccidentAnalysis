﻿using System;
using Microsoft.EntityFrameworkCore;

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