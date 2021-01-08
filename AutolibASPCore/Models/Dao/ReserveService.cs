using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
                throw new ServiceError("ReserveService.getStationsLibres()", "Unable to get all the stations");
            }
        }

        public static List <VehiculeInfo> getVehiculesLibresStation(int id)
        {
            try
            {
                var vehicules = (from s in context.Station
                                 join b in context.Borne on s.IdStation equals b.Station
                                 join v in context.Vehicule  on b.IdVehicule equals v.IdVehicule
                                 join t in context.TypeVehicule on v.TypeVehicule equals t.IdTypeVehicule
                                 where s.IdStation == id && v.Disponibilite == "LIBRE"

                                 select new VehiculeInfo()
                                 {
                                     Categorie = t.Categorie,
                                     ImageVehicule = t.ImageVehicule,
                                     EtatBatterie = v.EtatBatterie,
                                     TypeVehicule = t.TypeVehicule1,
                                     IdVehicule = v.IdVehicule
                                 });

                return vehicules.ToList();
            }
            catch (Exception e)
            {
                throw new ServiceError("ReserveService.getVehiculesLibresStation()", "Unable to get all the vehicules from the station");
            }
        }

        public static VehiculeInfo getVehiculeInfo(int id)
        {
            try
            {
                var vehicule = (from v in context.Vehicule
                                join t in context.TypeVehicule on v.TypeVehicule equals t.IdTypeVehicule
                                where v.Disponibilite == "LIBRE" && v.IdVehicule == id
                                 select new VehiculeInfo()
                                 {
                                     Categorie = t.Categorie,
                                     ImageVehicule = t.ImageVehicule,
                                     EtatBatterie = v.EtatBatterie,
                                     TypeVehicule = t.TypeVehicule1,
                                     IdVehicule = v.IdVehicule
                                 });

                return vehicule.FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new ServiceError("ReserveService.getVehiculesLibresStation()", "Unable to get all the vehicules from the station");
            }
        }

        public static bool compareDate(string dateArrivee, string dateDepart)
        {
            DateTime timenowfull = DateTime.Now;
            DateTime timenow = new DateTime(timenowfull.Year, timenowfull.Month, timenowfull.Day);

            DateTime dateArriveeDT = DateTime.Parse(dateArrivee);
            DateTime dateDepartDT = DateTime.Parse(dateDepart);

            int arriveeInfDepart = DateTime.Compare(dateArriveeDT, dateDepartDT);
            int arriveeInfNow = DateTime.Compare(dateArriveeDT, timenow);

            if(arriveeInfDepart > 0  || arriveeInfNow > 0)
            {
                return false;
            }

            return true;
        }

        public static void reserveVehicule(int vehiculeID, int userId, string dateDepart, string dateArrivee)
        {
            try
            {
                DateTime datedepart = DateTime.Parse(dateDepart);
                DateTime datearrivee = DateTime.Parse(dateArrivee);

                var reservation = new Reservation
                {
                    Vehicule = vehiculeID,
                    Client = userId,
                    DateReservation = datedepart,
                    DateEcheance = datearrivee
                };

                //On ajoute la réservation 
                context.Add(reservation);
                //On change le vehicule de libre à reserve
                var vehicule = context.Vehicule.Where(v => v.IdVehicule == vehiculeID).First();

                vehicule.Disponibilite = "RESERVE";

                //On update la table Utilise avec la borne de départ
                var bornedepart = (from b in context.Borne
                                   join v in context.Vehicule on b.IdVehicule equals v.IdVehicule
                                   where v.IdVehicule == vehiculeID
                                   select b.IdBorne);

                int idbornedepart = bornedepart.FirstOrDefault();

                var utilise = new Utilise
                {
                    Vehicule = vehiculeID,
                    Client = userId,
                    Date = datedepart,
                    BorneDepart = idbornedepart
                };

                context.Add(utilise);
                context.SaveChanges();

            }
            catch (Exception)
            {
                throw new ServiceError("ReserveService.reserveVehicule()", "Unable to add the reserved vehicule");
            }
        }

    }
}
