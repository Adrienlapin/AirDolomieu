using System;
using System.Collections.Generic;

namespace AirDolomieu.Class
{
    public partial class Pilote
    {
        public Pilote()
        {
            Vols = new HashSet<Vol>();
        }

        public int Numpilote { get; set; }
        public string? Nompilote { get; set; }
        public string? Adresse { get; set; }

        public virtual ICollection<Vol> Vols { get; set; }
    }
}
