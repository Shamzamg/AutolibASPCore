using System;
using System.Collections.Generic;

namespace AutolibASPCore.Models.Domain
{
    public class MapMarkerData
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Adresse { get; set; }
        public string TypeVehicule { get; set; }
    }
}
