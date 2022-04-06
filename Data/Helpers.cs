using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace UtahMotorVehicleAccidentAnalysis.Data
{
    public class Helpers
    {
        public static string GetRDSConnectionString()
        {
            var appConfig = ConfigurationManager.AppSettings;

            string dbname = appConfig["RDS_DB_NAME"];

            if (string.IsNullOrEmpty(dbname)) return null;

            string username = appConfig["admin"];
            string password = appConfig["Group49!"];
            string hostname = appConfig["accidents-db.crsciat1hkrn.us-west-1.rsd.amazonaws.com"];
            string port = appConfig["3306"];

            return "server=" + hostname + ";port=" + port + ";database=" + dbname + ";user=" + username + ";password=" + password + ";";
        }
    }
}
