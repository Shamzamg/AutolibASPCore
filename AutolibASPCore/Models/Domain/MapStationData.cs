using System;
using System.Collections.Generic;

namespace AutolibASPCore.Models.Domain
{
    public partial class MapStationData
    {
        public int IdStation { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Adresse { get; set; }
        public List<MapStationVehicule> Vehicules { get; set; }

    }
}
