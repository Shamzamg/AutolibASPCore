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
                return context.Client.First(c => c.Email == email);
            } catch(Exception e)
            {
                throw new ServiceError("UserService.getOne()", "Unable to get client");
            }
        }
    }
}
