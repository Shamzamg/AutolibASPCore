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
                return context.Client.FirstOrDefault(c => c.Email == email);
            } catch(Exception)
            {
                throw new ServiceError("UserService.getOne()", "Unable to get client");
            }
        }
        public static void addOne(string email, string passwd, string firstname, string lastname, DateTime birthdate)
        {
            try
            {
                var client = new Client { 
                    Email = email, Passwd = passwd, 
                    Nom = lastname, Prenom = firstname, 
                    DateNaissance = birthdate, 
                };
                context.Add(client);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw new ServiceError("UserService.getOne()", "Unable to add client");
            }
        }
    }
}
