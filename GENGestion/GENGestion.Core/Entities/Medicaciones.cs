using System;
using System.Collections.Generic;

namespace GENGestion.Core.Entities
{
    public partial class Medicaciones
    {
        public Medicaciones()
        {
            Informes = new HashSet<Informes>();
        }

        public int Id { get; set; }
        public string DeMedicacion { get; set; }

        public virtual ICollection<Informes> Informes { get; set; }
    }
}
