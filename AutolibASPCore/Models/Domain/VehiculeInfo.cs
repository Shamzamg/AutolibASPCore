using System;
using System.Collections.Generic;

namespace AutolibASPCore.Models.Domain
{
    public partial class VehiculeInfo
    {
        public int IdVehicule { get; set; }
        public string Categorie { get; set; }
        public string TypeVehicule { get; set; }
        public int? EtatBatterie { get; set; }

        public string ImageVehicule { get; set; }
    }
}
