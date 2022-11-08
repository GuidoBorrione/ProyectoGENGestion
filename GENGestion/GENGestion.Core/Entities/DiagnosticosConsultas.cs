using System;
using System.Collections.Generic;

namespace GENGestion.Infrastructure.Data
{
    public partial class DiagnosticosConsultas
    {
        public int DiagnosticoId { get; set; }
        public int ConsultaId { get; set; }

        public virtual Consultas Consulta { get; set; }
        public virtual Diagnosticos Diagnostico { get; set; }
    }
}
