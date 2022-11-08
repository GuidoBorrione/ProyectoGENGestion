using System;
using System.Collections.Generic;

namespace GENGestion.Core.DTOs
{
    internal class Medicos
    {
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

    }
}
