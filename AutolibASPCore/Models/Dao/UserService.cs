using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutolibASPCore.Models.Domain;
using AutolibASPCore.Models.Error;

namespace AutolibASPCore.Models.Dao
{
    public class UserService
    {
        private static autolibContext context = new autolibContext();

        public static Client getOne(string email)
        {
            try
            {
                /*
                var reservations = (from c in context.Client join r in context.Reservation 
                              on c.IdClient equals r.Client where c.Email == email select r);
                */
                return context.Client.First(c => c.Email == email);
            } catch(Exception)
            {
                throw new ServiceError("UserService.getOne()", "Unable to get client");
            }
        }
    }
}
