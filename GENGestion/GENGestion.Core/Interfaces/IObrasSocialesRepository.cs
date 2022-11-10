using GENGestion.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GENGestion.Core.Interfaces
{
    public interface IObrasSocialesRepository
    {
        public string GetNombreObrasSociales();

        Task<IEnumerable<ObrasSociales>> GetObrasSociales();
    }
}
