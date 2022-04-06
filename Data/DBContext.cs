using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace UtahMotorVehicleAccidentAnalysis.Data
{
    public class RDSContext : ApplicationDbContext
    {
        public RDSContext()
            : base(GetRDSConnectionString())
        {

        }
        public static RDSContext Create()
        {
            return new RDSContext();
        }

    }
}
