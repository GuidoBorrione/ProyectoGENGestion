using System;
using System.Collections.Generic;

namespace GENGestion.Core.DTOs
{
    internal class InformesDTO
    {
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

    }
}
