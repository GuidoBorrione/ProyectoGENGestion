using System;
using System.Collections.Generic;

namespace GENGestion.Core.DTOs
{
    internal class Consultas
    {

        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public DateTime FeConsulta { get; set; }
        public string DeAntecedenteEnfermedadActual { get; set; }
        public string DeMotivoConsulta { get; set; }
        public string DeExamenFisico { get; set; }
        public string DeIndicaciones { get; set; }
        public string DeTratamiento { get; set; }

    }
}
