using System;
using System.Collections.Generic;

namespace GENGestion.Core.Entities
{
    public partial class DiagnosticosInformes
    {
        public int DiagnosticoId { get; set; }
        public int InformeId { get; set; }

        public virtual Diagnosticos Diagnostico { get; set; }
        public virtual Informes Informe { get; set; }
    }
}
