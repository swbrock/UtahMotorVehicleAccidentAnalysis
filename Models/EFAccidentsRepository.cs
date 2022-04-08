using System;
using System.Linq;
using UtahMotorVehicleAccidentAnalysis.Models;

namespace UtahMotorVehicleAccidentAnalysis.Models
{
    public class EFAccidentsRepository : IAccidentsRepository
    {
        private AccidentsDbContext context { get; set; }

        public EFAccidentsRepository (AccidentsDbContext temp)
        {
            context = temp;
        }

        public IQueryable<Accident> Accidents => context.Accidents;

        public void SaveAccident(Accident b)
        {
            throw new NotImplementedException();
        }

        public void CreateAccident(Accident b)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccident(Accident b)
        {
            throw new NotImplementedException();
        }
    }
}
