using System;
using System.Collections.Generic;

namespace AirDolomieu.Class
{
    public partial class Avion
    {
        public Avion()
        {
            Vols = new HashSet<Vol>();
        }

        public int Numavion { get; set; }
        public string? Nomavion { get; set; }
        public int? Capacite { get; set; }
        public string Localisation { get; set; } = null!;

        public virtual ICollection<Vol> Vols { get; set; }
    }
}
