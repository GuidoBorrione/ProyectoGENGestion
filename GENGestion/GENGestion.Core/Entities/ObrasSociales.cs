using System;
using System.Collections.Generic;

namespace GENGestion.Core.Entities
{
    public partial class ObrasSociales
    {
        public ObrasSociales()
        {
            Pacientes = new HashSet<Pacientes>();
        }

        public int Id { get; set; }
        public string DeCodigoObraSocial { get; set; }
        public string DeObraSocial { get; set; }

        public virtual ICollection<Pacientes> Pacientes { get; set; }
    }
}
