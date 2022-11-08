using System;
using System.Collections.Generic;

namespace GENGestion.Infrastructure.Data
{
    public partial class Localidades
    {
        public Localidades()
        {
            Medicos = new HashSet<Medicos>();
            Pacientes = new HashSet<Pacientes>();
        }

        public int Id { get; set; }
        public int ProvinciaId { get; set; }
        public string DeLocalidad { get; set; }
        public string DeCdPostal { get; set; }

        public virtual Provincias Provincia { get; set; }
        public virtual ICollection<Medicos> Medicos { get; set; }
        public virtual ICollection<Pacientes> Pacientes { get; set; }
    }
}
