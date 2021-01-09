using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutolibASPCore.Models.Domain;
using AutolibASPCore.Models.Error;

namespace AutolibASPCore.Models.Dao
{
    public class HomeService
    {
        private static autolibContext context = new autolibContext();

        public static List<TypeVehicule> getAllVehicules()
        {
            try
            {
                var vehicules= (from t in context.TypeVehicule select t); 
                return vehicules.ToList();
            } 
            catch (Exception e)
            {
                throw new ServiceError("HomeService.getAllVehicules()", "Unable to get all the vehicules");
            }
        }
    }
}