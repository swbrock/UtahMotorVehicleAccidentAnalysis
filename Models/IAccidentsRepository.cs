using System;
using System.Linq;

namespace UtahMotorVehicleAccidentAnalysis.Models
{
    public interface IAccidentsRepository
    {
        IQueryable<Accident> Accidents { get; }
        public void SaveAccident(Accident b);

        public void CreateAccident(Accident b);

        public void DeleteAccident(Accident b);
    }
}
