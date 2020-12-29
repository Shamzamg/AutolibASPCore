using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutolibASPCore.Models.Domain;
using AutolibASPCore.Models.Error;

namespace AutolibASPCore.Models.Dao
{
    public class ReserveService
    {
        private static autolibContext context = new autolibContext();

        public static List<Station> getStationsLibres()
        {
            try
            {
                var listeStations = (from s in context.Station select s);
                return listeStations.ToList();
            }
            catch (Exception e)
            {
                throw new ServiceError("UserService.getBorneLibres()", "Unable to get all the bornes");
            }
        }

    }
}