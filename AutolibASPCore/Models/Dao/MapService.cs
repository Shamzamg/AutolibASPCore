using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutolibASPCore.Models.Domain;
using AutolibASPCore.Models.Error;

namespace AutolibASPCore.Models.Dao
{
    public class MapService
    {
        private static autolibContext context = new autolibContext();

        public static List<MapStationData> getStationsData ()
        {
            try
            {
                var listeMarkers = (from s in context.Station 
                                     select new MapStationData() {Adresse = s.Adresse, Latitude = s.Latitude, Longitude = s.Longitude, 
                                         Vehicules = ( from v in context.Vehicule join b in context.Borne on v.IdVehicule equals b.IdVehicule
                                                       join t in context.TypeVehicule on v.TypeVehicule equals t.IdTypeVehicule where b.Station == s.IdStation 
                                                       select new MapStationVehicule() {ModelVehicule = t.TypeVehicule1}).ToList()
                                     });
                return listeMarkers.ToList();
            } 
            catch (Exception e)
            {
                throw new ServiceError("MapService.getMarkerData()", "Unable to get all the markers data");
            }
        }
    }
}