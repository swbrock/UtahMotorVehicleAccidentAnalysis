using System;
using System.Linq;

namespace UtahMotorVehicleAccidentAnalysis.Models
{
    public interface IAccidentsRepository
    {
        IQueryable<Accident> Accidents { get; }
    }
}
