using System;
using System.Collections.Generic;

namespace GENGestion.Infrastructure.Data
{
    public partial class Pacientes
    {
        public Pacientes()
        {
            Consultas = new HashSet<Consultas>();
            Informes = new HashSet<Informes>();
        }

        public int Id { get; set; }
        public int LocalidadId { get; set; }
        public int ObraSocialId { get; set; }
        public int TipoPacienteId { get; set; }
        public string DeNombre { get; set; }
        public string DeApellido { get; set; }
        public string DeDomicilio { get; set; }
        public string DeTipoDocumento { get; set; }
        public long NuDocumento { get; set; }
        public DateTime FeNacimiento { get; set; }
        public string DeSexo { get; set; }
        public string DeTelefono { get; set; }
        public string DeCelular { get; set; }
        public string DeEmail { get; set; }
        public DateTime FeAlta { get; set; }
        public string DeOcupacion { get; set; }
        public string DeNumeroAfiliado { get; set; }

        public virtual Localidades Localidad { get; set; }
        public virtual ObrasSociales ObraSocial { get; set; }
        public virtual TiposDePacientes TipoPaciente { get; set; }
        public virtual ICollection<Consultas> Consultas { get; set; }
        public virtual ICollection<Informes> Informes { get; set; }
    }
}
