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

        public void SaveAccident(Accident a)
        {
            context.Update(a);
            context.SaveChanges();
        }

        public void CreateAccident(Accident a)
        {
            context.Add(a);
            context.SaveChanges();
        }

        public void DeleteAccident(Accident a)
        {
            context.Remove(a);
            context.SaveChanges();
        }
    }
}
