using System;
using System.Collections.Generic;

namespace GENGestion.Core.DTOs
{
    internal class LocalidadesDTO
    {
        public int Id { get; set; }
        public int ProvinciaId { get; set; }
        public string DeLocalidad { get; set; }
        public string DeCdPostal { get; set; }

    }
}
