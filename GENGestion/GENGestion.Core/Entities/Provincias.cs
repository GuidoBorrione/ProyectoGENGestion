using System;
using System.Collections.Generic;

namespace GENGestion.Infrastructure.Data
{
    public partial class Provincias
    {
        public Provincias()
        {
            Localidades = new HashSet<Localidades>();
        }

        public int Id { get; set; }
        public string DeProvincia { get; set; }

        public virtual ICollection<Localidades> Localidades { get; set; }
    }
}
