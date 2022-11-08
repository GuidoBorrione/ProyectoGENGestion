using System;
using System.Collections.Generic;

namespace GENGestion.Infrastructure.Data
{
    public partial class Medicos
    {
        public Medicos()
        {
            Consultas = new HashSet<Consultas>();
            InformesMedicoAnestesista = new HashSet<Informes>();
            InformesMedicoReferente = new HashSet<Informes>();
            InformesMedicoTratante = new HashSet<Informes>();
        }

        public int Id { get; set; }
        public int LocalidadId { get; set; }
        public string NuMatricula { get; set; }
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
        public virtual ICollection<Consultas> Consultas { get; set; }
        public virtual ICollection<Informes> InformesMedicoAnestesista { get; set; }
        public virtual ICollection<Informes> InformesMedicoReferente { get; set; }
        public virtual ICollection<Informes> InformesMedicoTratante { get; set; }
    }
}
