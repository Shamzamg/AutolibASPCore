using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutolibASPCore.Models.Domain;
using AutolibASPCore.Models.Error;

namespace AutolibASPCore.Models.Dao
{
    public class ReservationService
    {
        private static autolibContext context = new autolibContext();

        public static List<ReservationInfo> getReservation(int userId)
        {
            try
            {
                var reservations = (from r in context.Reservation 
                                    join v in context.Vehicule on r.Vehicule equals v.IdVehicule
                                    join t in context.TypeVehicule on v.TypeVehicule equals t.IdTypeVehicule
                                    join u in context.Utilise on v.IdVehicule equals u.Vehicule
                                    where r.Client==userId
                                    select new ReservationInfo()
                                    {
                                        userId = userId,
                                        IdVehicule = v.IdVehicule,
                                        Categorie = t.Categorie,
                                        ImageVehicule = t.ImageVehicule,
                                        TypeVehicule = t.TypeVehicule1,
                                        DateEcheance = r.DateEcheance,
                                        DateReservation = r.DateReservation,
                                        BorneDepart = u.BorneDepart
                                    });

                return reservations.ToList();
            } 
            catch (Exception e)
            {
                throw new ServiceError("ReservationService.getReservation()", "Unable to get all the reservations");
            }
        }

        public static List<int> getBornesLibres()
        {
            try
            {
                var bornesLibres = (from b in context.Borne
                                    where b.EtatBorne == false
                                    select b.IdBorne);

                return bornesLibres.ToList();
            }
            catch (Exception e)
            {
                throw new ServiceError("ReservationService.getBornesLibres()", "Unable to get all the bornes");
            }
        }

        public static void annulerReservation(int idClient,int idVehicule,int idBorneDepart)
        {
            try
            {
                var vehicule = context.Vehicule.Where(v => v.IdVehicule == idVehicule).First();

                vehicule.Disponibilite = "LIBRE";

                context.Remove(context.Utilise.Single(u => u.Vehicule == idVehicule && u.BorneDepart == idBorneDepart && u.Client == idClient));

                context.Remove(context.Reservation.Single(r => r.Vehicule == idVehicule && r.Client == idClient));

                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new ServiceError("ReservationService.renduVehicule()", "Unable to set the final borne");
            }
        }

        public static void renduVehicule(int idBorneArrivee, int idClient,int idVehicule,int idBorneDepart)
        {
            try
            {
                var utilise = context.Utilise.Where(u => u.Vehicule == idVehicule && u.BorneDepart == idBorneDepart && u.Client == idClient).First();

                utilise.BorneArrivee = idBorneArrivee;

                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new ServiceError("ReservationService.renduVehicule()", "Unable to set the final borne");
            }
        }
    }
}

