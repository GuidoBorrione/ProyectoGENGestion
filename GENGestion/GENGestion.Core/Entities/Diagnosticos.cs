using System;
using System.Collections.Generic;

namespace GENGestion.Infrastructure.Data
{
    public partial class Diagnosticos
    {
        public Diagnosticos()
        {
            DiagnosticosConsultas = new HashSet<DiagnosticosConsultas>();
            DiagnosticosInformes = new HashSet<DiagnosticosInformes>();
        }

        public int Id { get; set; }
        public string DeCodigoDiagnostico { get; set; }
        public string DeDiagnostico { get; set; }

        public virtual ICollection<DiagnosticosConsultas> DiagnosticosConsultas { get; set; }
        public virtual ICollection<DiagnosticosInformes> DiagnosticosInformes { get; set; }
    }
}
