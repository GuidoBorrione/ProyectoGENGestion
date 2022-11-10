using System;
using System.Collections.Generic;

namespace GENGestion.Core.Entities
{
    public partial class TiposDePacientes
    {
        public TiposDePacientes()
        {
            Pacientes = new HashSet<Pacientes>();
        }

        public int Id { get; set; }
        public string DeTipoPaciente { get; set; }

        public virtual ICollection<Pacientes> Pacientes { get; set; }
    }
}
