using System;
using System.Collections.Generic;

namespace AutolibASPCore.Models.Domain
{
    public partial class ReservationInfo
    {
        public int userId { get; set; }
        public int BorneDepart { get; set; }
        public int IdVehicule { get; set; }
        public int BorneArrivee { get; set; }
        public string Categorie { get; set; }
        public string TypeVehicule { get; set; }
        public DateTime DateReservation { get; set; }
        public DateTime? DateEcheance { get; set; }
        public string ImageVehicule { get; set; }
    }
}
