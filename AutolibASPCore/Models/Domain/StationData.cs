using System;
using System.Collections.Generic;

namespace AutolibASPCore.Models.Domain
{
    public partial class StationData
    {

            public Borne Borne { get; set; }
            public Station Station { get; set; }
            public Vehicule Vehicule { get; set; }
            public TypeVehicule TypeVehicule { get; set; }
    }
}
