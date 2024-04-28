using System;
using System.Collections.Generic;

namespace AirDolomieu.Class
{
    public partial class Vol
    {
        public string Numvol { get; set; } = null!;
        public int Numpilote { get; set; }
        public int Numavion { get; set; }
        public string? Villedep { get; set; }
        public string? Villearr { get; set; }
        public string? Heuredep { get; set; }
        public string? Heurearr { get; set; }

        public virtual Avion NumavionNavigation { get; set; } = null!;
        public virtual Pilote NumpiloteNavigation { get; set; } = null!;
    }
}
