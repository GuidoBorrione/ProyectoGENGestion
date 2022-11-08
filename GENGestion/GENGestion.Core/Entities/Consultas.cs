using System;
using System.Collections.Generic;

namespace GENGestion.Infrastructure.Data
{
    public partial class Consultas
    {
        public Consultas()
        {
            DiagnosticosConsultas = new HashSet<DiagnosticosConsultas>();
        }

        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public DateTime FeConsulta { get; set; }
        public string DeAntecedenteEnfermedadActual { get; set; }
        public string DeMotivoConsulta { get; set; }
        public string DeExamenFisico { get; set; }
        public string DeIndicaciones { get; set; }
        public string DeTratamiento { get; set; }

        public virtual Medicos Medico { get; set; }
        public virtual Pacientes Paciente { get; set; }
        public virtual ICollection<DiagnosticosConsultas> DiagnosticosConsultas { get; set; }
    }
}
