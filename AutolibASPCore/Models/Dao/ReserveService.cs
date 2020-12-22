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

        public static List<StationData> getStationData (int id)
        {
            try
            {
                var listeStations = (from s in context.Station join b in context.Borne on s.IdStation equals b.Station
                                     join v in context.Vehicule on b.IdVehicule equals v.IdVehicule
                                     join t in context.TypeVehicule on v.IdVehicule equals t.IdTypeVehicule
                                     where s.IdStation == id
                                     select new StationData() {Station = s, Borne = b, Vehicule = v, TypeVehicule = t });
                return listeStations.ToList();
            }
            catch (Exception e)
            {
                throw new ServiceError("UserService.getBorneLibres()", "Unable to get all the bornes");
            }
        }
    }
}