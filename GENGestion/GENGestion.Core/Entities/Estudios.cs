using System;
using System.Collections.Generic;

namespace GENGestion.Infrastructure.Data
{
    public partial class Estudios
    {
        public Estudios()
        {
            Informes = new HashSet<Informes>();
        }

        public int Id { get; set; }
        public string DeCodigoEstudio { get; set; }
        public string DeEstudio { get; set; }

        public virtual ICollection<Informes> Informes { get; set; }
    }
}
