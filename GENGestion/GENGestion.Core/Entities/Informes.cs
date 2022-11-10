using System;
using System.Collections.Generic;

namespace GENGestion.Core.Entities
{
    public partial class Informes
    {
        public Informes()
        {
            DiagnosticosInformes = new HashSet<DiagnosticosInformes>();
        }

        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int MedicoReferenteId { get; set; }
        public int MedicoTratanteId { get; set; }
        public int MedicoAnestesistaId { get; set; }
        public int EstudioId { get; set; }
        public int MedicacionId { get; set; }
        public DateTime FeInforme { get; set; }
        public string DeMotivoInforme { get; set; }
        public string DeHallazgo { get; set; }
        public string DeEquipoUsado { get; set; }
        public string DeDescripcionPreparacion { get; set; }
        public string TiEstado { get; set; }

        public virtual Estudios Estudio { get; set; }
        public virtual Medicaciones Medicacion { get; set; }
        public virtual Medicos MedicoAnestesista { get; set; }
        public virtual Medicos MedicoReferente { get; set; }
        public virtual Medicos MedicoTratante { get; set; }
        public virtual Pacientes Paciente { get; set; }
        public virtual ICollection<DiagnosticosInformes> DiagnosticosInformes { get; set; }
    }
}
